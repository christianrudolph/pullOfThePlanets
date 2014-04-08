using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    public partial class AddOrb : Form
    {
        private MainWindow mw;

        public AddOrb(MainWindow mw)
        {
            this.mw = mw;
            InitializeComponent();
        }

        private void AddOrb_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < mw.getLayouts().Length; j++)
            {
                e_layout.Items.Add(mw.getLayouts()[j]);
                g_layout.Items.Add(mw.getLayouts()[j]);
                z_layout.Items.Add(mw.getLayouts()[j]);
                j++;
            } 
            List<Orb>.Enumerator i = mw.getOrbs().GetEnumerator();
            while (i.MoveNext())
            {
                z_center.Items.Add(((Orb)i.Current).getName());
            }


            // 1. Element auswählen
            if (e_layout.Items.Count > 0)
                e_layout.SelectedItem = e_layout.Items[0];
            if (g_layout.Items.Count > 0)
                g_layout.SelectedItem = g_layout.Items[0];
            if (z_layout.Items.Count > 0)
                z_layout.SelectedItem = z_layout.Items[0];
            if (z_center.Items.Count > 0)
                z_center.SelectedItem = z_layout.Items[0];
        }

        private void add_Click(object sender, EventArgs e) //Planet hinzufügen
        {
            try
            {
                // Ellipsentab im Focus
                if (tabs.SelectedIndex == 1)
                {
                    //Eingabe auslesen
                    double[] p = { Convert.ToDouble(e_x_position.Text),
                               Convert.ToDouble(e_y_position.Text),
                               Convert.ToDouble(e_z_position.Text) };
                    double[] axis = { Convert.ToDouble(e_greataxis.Text),
                                  Convert.ToDouble(e_littleaxis.Text)};

                    //Planet hinzufügen (Mesh und Objekt)
                    mw.add(e_name.Text, (float)Convert.ToDouble(e_radius.Text), p, Convert.ToDouble(e_speed.Text),
                           e_layout.Text, axis);
                }
                // Gravitionstab im Focus
                else if (tabs.SelectedIndex == 0)
                {

                    //Eingabe auslesen
                    double[] p = { Convert.ToDouble(g_x_position.Text),
                               Convert.ToDouble(g_y_position.Text),
                               Convert.ToDouble(g_z_position.Text) };
                    double[] v = { Convert.ToDouble(g_x_speed.Text),
                               Convert.ToDouble(g_y_speed.Text),
                               Convert.ToDouble(g_z_speed.Text)};

                    //Planet hinzufügen (Mesh und Objekt)
                    mw.add(g_name.Text, (float)Convert.ToDouble(g_radius.Text),
                           Convert.ToDouble(g_mass.Text), p, v, g_layout.Text);
                }
                //eine Sonne im Focus
                else if (tabs.SelectedIndex == 2)
                {

                    //Eingabe auslesen
                    double[] p = { Convert.ToDouble(z_x_position.Text),
                               Convert.ToDouble(z_y_position.Text),
                               Convert.ToDouble(z_z_position.Text) };
                    double[] v = { Convert.ToDouble(z_x_speed.Text),
                               Convert.ToDouble(z_y_speed.Text),
                               Convert.ToDouble(z_z_speed.Text)};

                    //Planet hinzufügen (Mesh und Objekt)
                    mw.add(z_name.Text, (float)Convert.ToDouble(z_radius.Text),
                           Convert.ToDouble(z_mass.Text), p, v, z_layout.Text, z_center.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Fehler in den geöffneten Planeten.");
                }
                //Fenster schließen
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Hinzufügen. Falsche Eingabe?");
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //Fenster schließen
            this.Close();
        }
    }
}