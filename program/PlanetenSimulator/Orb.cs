using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Drawing;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    public class Orb
    {

        // Eigenschaften des Himmelskörpers
        protected string name;       // Name
        protected float radius;      // Radius
        protected string layout;     // Planetenlayout
        protected double[] position; // Position {x,y,z}
        protected string methode;    // Berechnungsmethode

        protected float lastCalc;    // letzte Aktualisierung;
        protected Mesh myMesh;       // Mesh des Himmelskörpers
        protected MainWindow mw;     // Verweis auf das Hauptfenster

        private int equPositions;  // Liste gleicher Positionen

        // Letzte Position
        protected List<double[]> lastPositions = new List<double[]>();
        // Wird berechnet? Ja / Nein
        public bool isThreated = false;

        private bool delete = false;

        // Bestimmung der nächsten Position und Speicherung der Alten
        public double[] nextPositon(List<Orb> orbs)
        {
            if (lastPositions.Count > 0)
            {
                double[] posN = lastPositions[(lastPositions.Count - 1)];
                if (!posN.Equals(position) && equPositions < 11)
                {
                    // Nicht gleich der Letzten und Ablauf nicht schon gespeichert
                    double abstand = Math.Sqrt(Math.Pow(position[0] - posN[0], 2) + Math.Pow(position[1] - posN[1], 2) + Math.Pow(position[2] - posN[2], 2));
                    if (abstand > mw.getPositionAbstand())
                    {
                        // Erfüllt einen mindest Abstand
                        lastPositions.Add((double[])position.Clone());

                        if (lastPositions.IndexOf(position) == -1)
                            equPositions = 0;
                        else
                            equPositions++;
                    }
                }
            }
            else
                lastPositions.Add((double[])position.Clone());

            if(methode == "Ellipse")
                return doCalc();
            return doCalc(orbs);
        }

        // Zum Layoutnamen die Farbe ermitteln
        public int layoutToColor(string layout)
        {
            string[] layouts = mw.getLayouts();
            for (int i = 0; i < layouts.Length; i++)
            {
                if (layouts[i].Equals(layout))
                {
                    return Color.FromName(layouts[i + 1]).ToArgb();
                }
                i++;
            }
            return Color.DeepSkyBlue.ToArgb();
        }

        protected virtual double[] doCalc(List<Orb> orbs)
        {
            return new double[3];
        }
        protected virtual double[] doCalc()
        {
            return new double[3];
        }

        // Alles entfernen löschen
        ~Orb() // Destruktor
        {
            lastPositions.Clear();
            myMesh.Dispose();
        }

        // Getter und Setter

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public float getRadius()
        {
            return radius;
        }
        public void setRadius(float newRadius)
        {
            radius = newRadius;
            Device device = mw.getDevice();
            VertexFormats format = VertexFormats.PositionNormal | VertexFormats.Diffuse;
            Mesh newMesh = Mesh.Sphere(device, radius, 100, 100);
            //Mesh newMesh = Mesh.Teapot(device);
            Mesh tempBox = newMesh.Clone(newMesh.Options.Value, format, device);
            newMesh.Dispose();
            myMesh = tempBox;
        }

        public string getLayout()
        {
            return layout;
        }
        public void setLayout(string layout)
        {
            this.layout = layout;

            Mesh tempMesh = myMesh;

            CustomVertex.PositionNormalColored[] verts = (CustomVertex.PositionNormalColored[])tempMesh.VertexBuffer.Lock(0,
                    typeof(CustomVertex.PositionNormalColored),
                    LockFlags.None,
                    tempMesh.NumberVertices);

            int color = layoutToColor(layout);

            //Farbe neue PlanetenMesh
            for (int j = 0; j < verts.Length; j++)
            {
                verts[j].Color = color;
            }
            tempMesh.VertexBuffer.Unlock();
            myMesh = tempMesh;
        }
        public double[] getPosition()
        {
            return position;
        }
        public void setPosition(double[] position)
        {
            this.position = position;
        }

        public string getMethode()
        {
            return methode;
        }

        public Mesh getMesh() {
            return myMesh;
        }

        public List<double[]> getLastPositions()
        {
            return lastPositions;
        }
        public void clearLastPositions()
        {
            lastPositions.Clear();
        }

        public bool getDelete()
        {
            return delete;
        }
        public void setDelete()
        {
            delete = true;
        }
    }
}
