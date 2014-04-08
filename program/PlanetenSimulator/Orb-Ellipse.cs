using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetenSimulator
{
    partial class Orb_Ellipse : Orb
    {
        // Eigenschaften des Himmelskörpers
        private double v;     // Geschwindigkeit
        public double[] axis; // Halbachsen {Große,Kleine}

        // Attribute zur Berechnung
        private bool startAngle = false;
        private double yTranslation = 0;
        private double angle = 0;

        public Orb_Ellipse(string name, float radius, double[] position, double v, string layout, double[] axis, MainWindow mw)
        {
            this.mw = mw;

            setRadius(radius);
            setLayout(layout);

            this.layout = layout;
            this.methode = "Ellipse";
            this.position = position;
            this.name = name;
            this.v = v;
            this.axis = axis;

            lastCalc = 0;
        }

        // Berechnung der Ellipsenbahn
        protected override double[] doCalc()
        {
            /*//Brennpunkt x-wert
            double f1 = Math.Sqrt((a * a) - (b * b));

            //Verschiebung der Ellipse,sodass der Brennpunkt stimmt
            double shift = focus + f1;
            */
            // Variablen
            double tick = mw.getTick();
            angle += (Math.PI / 360) * tick;

            if (!startAngle)
            {
                startAngle = true;
                angle = Math.Acos(position[0] * axis[0]);

                yTranslation = (axis[1] * Math.Sin(angle)) - position[1];
            }

            position[0] = axis[0] * Math.Cos(angle);
            position[1] = axis[1] * Math.Sin(angle) - yTranslation;

            return position;
        }

        // Getter und Setter
        public double getV()
        {
            return v;
        }
        public void setV(double v)
        {
            this.v = v;
        }

        public double[] getAxis()
        {
            return axis;
        }
        public void setAxis(double[] axis)
        {
            this.axis = axis;
        }
    }
}
