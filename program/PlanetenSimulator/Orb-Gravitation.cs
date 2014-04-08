using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    class Orb_Gravitation : Orb
    {

        // Eigenschaften des Himmelskörpers
        private double masse; // Masse
        private double[] v;   // Geschwindigkeit {x,y,z}

        public Orb_Gravitation(string name, float radius, double masse, double[] position, double[] v, string layout, MainWindow mw)
        {
            this.mw = mw;

            setRadius(radius);
            setLayout(layout);

            this.layout = layout;
            this.methode = "Gravitation";
            this.masse = masse;
            this.position = position;
            this.v = v;
            this.name = name;

            lastCalc = 0;
        }

        // Berechnung der Bahn
        protected override double[] doCalc(List<Orb> orbs)
        {
            //nächste Position berechnen mit v,position und masse
            try
            {
                //Konstante 
                double gConst = 6.673e-11; //Gravitationskonstante 

                double t = mw.getTick(); ; // Intervall

                //Berechnete 
                double abstand; //Abstand Planet Sonne (Mittelpunkt) 
                double _g; //Fallbeschleunigung komplett
                double[] gPrev = new double[3]; //Fallbeschleunigung als Vektor der vorigen Planeten
                gPrev[0] = gPrev[1] = gPrev[2] = 0; //anfangs null
                double[] g = new double[3]; //Fallbeschleunigung (als Vektor (x,y,z)) auf Komponenten zerlegt 

                List<Orb>.Enumerator n = orbs.GetEnumerator();
                while (n.MoveNext())
                {
                    if (!(n.Current).Equals(this) && ((n.Current) is Orb_Gravitation))
                    {
                        Orb_Gravitation orb = (Orb_Gravitation)n.Current;

                        //Daten von Körper n (Current) 
                        double masseN = orb.getMasse();
                        double[] posN = orb.getPosition();

                        abstand = Math.Sqrt(Math.Pow(position[0] - posN[0], 2) + Math.Pow(position[1] - posN[1], 2) + Math.Pow(position[2] - posN[2], 2));


                        //Zusammenstoß
                        if (abstand <= (this.getRadius() + orb.getRadius())) //Zusammenstoß, Masse wird auf den schwerern Körper übertragen, anderer wird gelöscht
                        {
                            if (this.getMasse() <= orb.getMasse())
                            {
                                orb.setMasse(orb.getMasse() + this.getMasse());
                                this.setMasse(0);
                                this.setDelete();

                                return new double[3];
                            }
                            else
                            {
                                this.setMasse(orb.getMasse() + this.getMasse());
                                orb.setMasse(0);
                                orb.setDelete();
                            }
                        }

                        _g = -gConst * masseN / (abstand * abstand);
                        for (int i = 0; i < 3; i++) // g berechnen 
                        {
                            g[i] = gPrev[i] + _g * (position[i] - posN[i]) / abstand;
                            gPrev[i] = g[i];
                            // g (inkl. Anziehungskräfte vorheriger Planeten (<n)) 

                        }
                    }

                }
                for (int i = 0; i < 3; i++) // v und neue position berechnen 
                {
                    v[i] = v[i] + g[i] * t; // v 
                    position[i] = position[i] + v[i] * t + 0.5f * g[i] * t * t; //position 
                }
                return position;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
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
    }
}
