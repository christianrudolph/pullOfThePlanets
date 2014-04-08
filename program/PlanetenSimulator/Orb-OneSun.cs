using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetenSimulator
{
    class Orb_OneSun : Orb
    {
        // Eigenschaften des Himmelskörpers
        private double masse; // Masse
        private double[] v;   // Geschwindigkeit {x,y,z}
        public int center;    // Nummer des Bezugskörpers



        public Orb_OneSun(string name, float radius, double masse, double[] position, double[] v, string layout,int center, MainWindow mw)
        {
            this.mw = mw;

            setRadius(radius);
            setLayout(layout);

            this.layout = layout;
            this.methode = "EineSonne";
            this.masse = masse;
            this.position = position;
            this.v = v;
            this.name = name;
            this.center = center;

            lastCalc = 0;
        }

        // Berechnung der Bahn mit einem Gravitationszentrum
        protected override double[] doCalc(List<Orb> orbs)
        {   //nächste Position berechnen mit v,position und Sonnenmasse


            // Konstanten
            double gConst = 6.673e-11; //Gravitationskonstante

            double t = mw.getTick(); // Intervall

            double abstand; //Abstand Planet Sonne (Mittelpunkt)
            double _g; //Fallbeschleunigung komplett
            double[] g = new double[3]; //Fallbeschleunigung (als Vektor (x,y,z)) auf Komponenten zerlegt
            double masseSonne = 0; // Zentrumsmasse
            double[] posN = new double[3]; //Position von Zentralkörper

            if(orbs[center] is Orb_Gravitation)
            {
                masseSonne = ((Orb_Gravitation)orbs[center]).getMasse();
                posN = ((Orb_Gravitation)orbs[center]).getPosition();
            }
            else
            {
                masseSonne = ((Orb_OneSun)orbs[center]).getMasse();
                posN = ((Orb_OneSun)orbs[center]).getPosition();
            }
            //abstand = Math.Sqrt(position[0] * position[0] + position[1] * position[1] + position[2] * position[2]);
            abstand = Math.Sqrt(Math.Pow(position[0] - posN[0], 2) + Math.Pow(position[1] - posN[1], 2) + Math.Pow(position[2] - posN[2], 2));
            _g = -gConst * masseSonne / (abstand * abstand);
            for (int i = 0; i < 3; i++) // g, berechnen
            {
                //g[i] = _g * position[i] / abstand; // g
                g[i] = _g * (position[i] - posN[i]) / abstand;
                v[i] = v[i] + g[i] * t; // v
                position[i] = position[i] + v[i] * t + 0.5f * g[i] * t * t; //position
            }
            return position;
        }

        // Getter und Setter
        public double getMasse()
        {
            return masse;
        }
        public void setMasse(double masse)
        {
            this.masse = masse;
        }

        public double[] getV()
        {
            return v;
        }
        public void setV(double[] v)
        {
            this.v = v;
        }

        public int getCenter() 
        {
            return center;
        }
        public void setCenter(int center)
        {
            this.center = center;
        }
    }
}
