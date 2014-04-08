using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;


namespace PlanetenSimulator
{
    class Graphic
    {
        //#############################
        //Variablen ###################
        //#############################
        private Device device = null;
        private PresentParameters presentParams = new PresentParameters();
        private Vector3 cameraPos = new Vector3(0, 0, 50f);
        private Vector3 cameraTarget = new Vector3(0, 0, 0);
        private float viewAngle = (float)Math.PI / 4.0f;
        private MainWindow mw = null;

        public enum ControlID { Fullscreen = 1, Options};

        public Graphic(MainWindow mw)
        {
            this.mw = mw;
        }

        public bool InitializeDirectX()
        {
            try
            {
                if (!InitializeGraphics()) // Direct3D initialisieren
                {
                    MessageBox.Show("Konnte Hardware nicht initialisieren.");
                    return false;
                }
                mw.Show();

                while (mw.Created)
                {
                    try
                    {
                        Render();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    Application.DoEvents();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        private PresentParameters getPresentParams()
        {
            PresentParameters pp = new PresentParameters();
            pp.AutoDepthStencilFormat = DepthFormat.D16;
            pp.EnableAutoDepthStencil = true;
            pp.BackBufferCount = 1;
            pp.BackBufferFormat = Format.X8R8G8B8;
            pp.BackBufferHeight = mw.ClientSize.Height;
            pp.BackBufferWidth = mw.ClientSize.Width;
            pp.Windowed = true;
            pp.PresentationInterval = PresentInterval.One;
            pp.SwapEffect = SwapEffect.Discard;
            return pp;
        }

        private bool InitializeGraphics()
        {
            try
            {
                device = new Device(Manager.Adapters.Default.Adapter, DeviceType.Hardware, mw, CreateFlags.HardwareVertexProcessing, getPresentParams());
                device.RenderState.ZBufferEnable = true;
                device.RenderState.CullMode = Cull.None;

                return true;
            }
            // Keine Hardwareunterstützung!
            catch (DirectXException)
            {
                // Test auf Softwareunterstützung!
                try
                {
                    device = new Device(Manager.Adapters.Default.Adapter, DeviceType.Software, mw, CreateFlags.HardwareVertexProcessing, getPresentParams());
                    device.RenderState.ZBufferEnable = true;
                    device.RenderState.CullMode = Cull.None;
                    return true;
                }
                // Kein DirectX möglich!
                catch (DirectXException)
                {
                    return false;
                }
            }
        }

        private void Render()
        {
            try
            {
                if (device == null)
                    return;

                if (mw.getStop() && mw.getIsRunning())
                    mw.stopCalc();
                
                if (!mw.getStop() && !mw.getIsRunning())
                    mw.startCalc();

                device.Clear(ClearFlags.ZBuffer | ClearFlags.Target, Color.Black, 1.0f, 0);
                device.BeginScene();


                device.RenderState.Lighting = false;
                device.RenderState.CullMode = Cull.CounterClockwise;

                device.Transform.View = Matrix.LookAtLH(cameraPos,
                                                        cameraTarget,
                                                        new Vector3(0, 1f, 0));

                device.Transform.Projection = Matrix.PerspectiveFovLH(viewAngle, // Blickfeldwinkel (PI/4 = 45°)
                                                                      (float)mw.Width / mw.Height, // Seitenverhältnis
                                                                      1, mw.getDeep()); // Vordere u. hintere Z-Ebene

                //############################################
                // orbsMesh    ###############################
                //############################################

                List<Orb>.Enumerator i = mw.getOrbs().GetEnumerator();

                Matrix world = Matrix.Identity;
                while (i.MoveNext())
                {
                    Orb orb = (Orb)i.Current;

                    double[] position = orb.getPosition();

                    world = Matrix.Scaling(1.0f, 1.0f, 1.0f);
                    world *= Matrix.Translation((float)position[0], (float)position[1], (float)position[2]);
                    world *= Matrix.RotationX(1);
                    device.Transform.World = world;
                    orb.getMesh().DrawSubset(0);

                    // Bahn zeichnen
                    paintLine(orb);
                }
                // Berechnungen abgeschlossen

                device.EndScene();
                device.Present();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Zeichnen für den übergebenen Planet eine Bahn nach gespeicherten Positionen
        public void paintLine(Orb orb)
        {
            List<double[]> lastPos = orb.getLastPositions();
            int count = lastPos.Count;
            if (lastPos.Count > 2)
            {
                VertexBuffer lineBuffer = new VertexBuffer(typeof(CustomVertex.PositionColored),
                                                                  count, device, Usage.WriteOnly,
                                                                  CustomVertex.PositionColored.Format, Pool.Default);
                // Buffer erzeugen, der soviele Dreiecke, wie alte Positionen speichert
                GraphicsStream stream = lineBuffer.Lock(0, 0, 0);
                // Stream öffnen
                CustomVertex.PositionColored[] verts = new CustomVertex.PositionColored[count];

                // Positionen auf Dreiecke übersetzten
                for (int j = 0; j < count; j++)
                {
                    verts[j].X = (float)(lastPos[j][0] - orb.getPosition()[0]);
                    verts[j].Y = (float)(lastPos[j][1] - orb.getPosition()[1]);
                    verts[j].Z = (float)(lastPos[j][2] - orb.getPosition()[2]);
                    verts[j].Color = orb.layoutToColor(orb.getLayout());
                }
                stream.Write(verts);
                // Alle Dreiecke in den Stream
                lineBuffer.Unlock();
                // Dem Device den Stream mitteilen
                device.SetStreamSource(0, lineBuffer, 0);
                device.VertexFormat = CustomVertex.PositionColored.Format;
                // Und alle Punkte aus dem Stream verbinden
                device.DrawPrimitives(PrimitiveType.LineStrip, 0, (count - 1));
            }
        }
        public void screenShot()
        {
            string fileName = DateTime.Now.ToString( "yyyyMMdd" ) + "_" + DateTime.Now.TimeOfDay.ToString();
            // Remove colons and junk
            fileName = fileName.Remove( 11, 1 );
            fileName = fileName.Remove( 13, 1 );
            fileName = fileName.Remove( 15, 1 );
            Surface backbuffer = device.GetBackBuffer( 0, 0, BackBufferType.Mono );
            SurfaceLoader.Save( "Screenshots/" + fileName + ".png", ImageFileFormat.Png, backbuffer );
            backbuffer.Dispose();
        } 

        public Device getDevice()
        {
            return device;
        }
        public Vector3 getCameraPos()
        {
            return cameraPos;
        }
        public Vector3 getCameraTarget()
        {
            return cameraTarget;
        }
        public  void setCameraPos(Vector3 cameraPos)
        {
            this.cameraPos = cameraPos;
        }
        public void setCameraTarget(Vector3 cameraTarget)
        {
            this.cameraTarget = cameraTarget;
        }

        public void setViewAngle(float angle) 
        {
            viewAngle = angle;
        }
    }
}
