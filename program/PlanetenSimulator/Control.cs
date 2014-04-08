using System;
using System.Windows.Forms;
using Microsoft.DirectX;

namespace PlanetenSimulator
{
    class Control
    {
        //
        // Navigation in der 3-D Welt
        //
        Keys keyData;
        Message msg;

        private double phi = 0; // Horizontaler Winkel
        private double rho = 0; // Vertikaler Winkel

        public void updateEvent(ref Message msg, Keys keyData)
        {
            this.keyData = keyData;
            this.msg = msg;
        }

        public Vector3 getPos(Vector3 cameraPos)
        {
            double r = cameraPos.Length(); // Radius
            double factor = (Math.PI / 180);

            if (phi > (Math.PI * 2))
                phi = phi - (Math.PI * 2);

            if (keyData == Keys.W || keyData == Keys.Up)
            {
                rho = rho + factor;

                cameraPos.X = (float)(r * Math.Sin(rho) * Math.Cos(phi));
                cameraPos.Y = (float)(r * Math.Sin(rho) * Math.Sin(phi));
                cameraPos.Z = (float)(r * Math.Cos(rho));
            }
            else if (keyData == Keys.S || keyData == Keys.Down)
            {
                rho = rho + factor;

                cameraPos.X = (float)(r * Math.Sin(rho) * Math.Cos(phi));
                cameraPos.Y = (float)(r * Math.Sin(rho) * Math.Sin(phi));
                cameraPos.Z = (float)(r * Math.Cos(rho));
            }
            else if (keyData == Keys.A || keyData == Keys.Left)
            {
                phi = phi - factor;

                cameraPos.X = (float)(r * Math.Sin(rho) * Math.Cos(phi));
                cameraPos.Y = (float)(r * Math.Sin(rho) * Math.Sin(phi));
                cameraPos.Z = (float)(r * Math.Cos(rho));
            }
            else if (keyData == Keys.D || keyData == Keys.Right)
            {
                phi = phi + factor;

                cameraPos.X = (float)(r * Math.Sin(rho) * Math.Cos(phi));
                cameraPos.Y = (float)(r * Math.Sin(rho) * Math.Sin(phi));
                cameraPos.Z = (float)(r * Math.Cos(rho));
            }
            else if (keyData == Keys.Subtract || keyData == Keys.OemMinus )
            {
                cameraPos.Scale(1.1f);
            }
            else if (keyData == Keys.Add || keyData == Keys.Oemplus)
            {
                cameraPos.Scale(0.9f);
            }
            else if (keyData == Keys.R)
            {
                cameraPos.X = 0;
                cameraPos.Y = 0;
                cameraPos.Z = 50;
            }

            Console.WriteLine(cameraPos.X.ToString() + "-" + cameraPos.Y.ToString() + "-" + cameraPos.Z.ToString());
            return cameraPos;
        }

        public Vector3 getTarget(Vector3 cameraTarget)
        {
            return cameraTarget;
        } 
    }
}