using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    public partial class EditOrb : Form
    {
        private MainWindow mw;

        bool e_radiusChanged = false, g_radiusChanged = false, z_radiusChanged = false;
        bool e_layoutChanged = false, g_layoutChanged = false, z_layoutChanged = false;

        public EditOrb(MainWindow mw)
        {
            this.mw = mw;
            InitializeComponent();
        }

        private void editOrb_Load(object sender, EventArgs e)
        {
            //Combobox initialisieren
            List<Orb>.Enumerator i = mw.getOrbs().GetEnumerator();
            while (i.MoveNext())
            {
                orbList.Items.Add(((Orb)i.Current).getName());
                if(i.Current is Orb_Gravitation || i.Current is Orb_OneSun)
                    z_center.Items.Add(((Orb)i.Current).getName());
            }
            for (int j = 0; j < mw.getLayouts().Length; j++)
            {
                e_layout.Items.Add(mw.getLayouts()[j]);
                g_layout.Items.Add(mw.getLayouts()[j]);
                z_layout.Items.Add(mw.getLayouts()[j]);
                j++;
            }

            // 1. Element auswählen
            if (orbList.Items.Count > 0)
                orbList.SelectedItem = orbList.Items[0];
        }

        private void orbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orb orb = mw.getOrb(orbList.SelectedIndex);

            e_name.Text = g_name.Text = z_name.Text = orb.getName();
            e_radius.Text = g_radius.Text = z_radius.Text= orb.getRadius().ToString();

            z_x_position.Text  =e_x_position.Text = g_x_position.Text = orb.getPosition()[0].ToString();
            z_y_position.Text = e_y_position.Text = g_y_position.Text = orb.getPosition()[1].ToString();
            z_z_position.Text =e_z_position.Text = g_z_position.Text = orb.getPosition()[2].ToString();
            z_radius.Text = e_radius.Text = g_radius.Text = orb.getRadius().ToString();
          

            z_layout.SelectedItem = e_layout.SelectedItem = g_layout.SelectedItem = orb.getLayout();

            if (orb is Orb_Gravitation)
            {
                Orb_Gravitation sorb = (Orb_Gravitation)orb;

                //Alte werte in die textbox laden
                z_mass.Text = g_mass.Text = sorb.getMasse().ToString();

                z_x_speed.Text = g_x_speed.Text = sorb.getV()[0].ToString();
                z_y_speed.Text = g_y_speed.Text = sorb.getV()[1].ToString();
                z_z_speed.Text = g_z_speed.Text = sorb.getV()[2].ToString();

                tabs.SelectedIndex = 0;
            }
            else if (orb is Orb_OneSun)
            {
                Orb_OneSun sorb = (Orb_OneSun)orb;

                //alte werte in die textbox laden

                z_mass.Text = g_mass.Text = sorb.getMasse().ToString();
                
                z_x_speed.Text = g_x_speed.Text = sorb.getV()[0].ToString();
                z_y_speed.Text = g_y_speed.Text = sorb.getV()[1].ToString();
                z_z_speed.Text = g_z_speed.Text = sorb.getV()[2].ToString();

                z_center.SelectedIndex = sorb.getCenter();

                tabs.SelectedIndex = 2;
            }
            else if (orb is Orb_Ellipse)
            {
                Orb_Ellipse sorb = (Orb_Ellipse)orb;

                //Alte werte in die textbox laden

                e_speed.Text = sorb.getV().ToString();
                e_greataxis.Text = sorb.getAxis()[0].ToString();
                e_littleaxis.Text = sorb.getAxis()[1].ToString();

                tabs.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Fehler in den geöffneten Planeten.");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                //textboxinhalt auf Planet i anwenden
                //Gravitationsplanet
                if (tabs.SelectedIndex == 0)
                {
                    double[] p = { Convert.ToDouble(g_x_position.Text), Convert.ToDouble(g_y_position.Text), 
                                   Convert.ToDouble(g_z_position.Text) };

                    double[] v = { Convert.ToDouble(g_x_speed.Text), Convert.ToDouble(g_y_speed.Text),
                                   Convert.ToDouble(g_z_speed.Text) };

                    if (((Orb)mw.getOrb(orbList.SelectedIndex)).getMethode().Equals("Gravitation"))
                    {
                        Orb_Gravitation orb = (Orb_Gravitation)mw.getOrb(orbList.SelectedIndex);
                        orb.setName(g_name.Text);
                        orb.setMasse(Convert.ToDouble(g_mass.Text));

                        if (g_radiusChanged)
                            orb.setRadius((float)Convert.ToDouble(g_radius.Text));

                        if (g_layoutChanged)
                            orb.setLayout(g_layout.Text);



                        orb.setV(v);
                        orb.setPosition(p);
                        if (!oldLinies.Checked)
                            orb.clearLastPositions();
                    }
                    else
                    {
                        mw.delPlanet(orbList.SelectedIndex);
                        mw.add(g_name.Text, (float)Convert.ToDouble(g_radius.Text), Convert.ToDouble(g_mass.Text), p, v, g_layout.Text);
                    }
                }
                //Eine Sonne
                if (tabs.SelectedIndex == 2)
                {
                    double[] p = { Convert.ToDouble(z_x_position.Text), Convert.ToDouble(z_y_position.Text), 
                                   Convert.ToDouble(z_z_position.Text) };

                    double[] v = { Convert.ToDouble(z_x_speed.Text), Convert.ToDouble(z_y_speed.Text),
                                   Convert.ToDouble(z_z_speed.Text) };

                    if (((Orb)mw.getOrb(orbList.SelectedIndex)).getMethode().Equals("OneSun"))
                    {
                        Orb_OneSun orb = (Orb_OneSun)mw.getOrb(orbList.SelectedIndex);

                        orb.setName(z_name.Text);
                        orb.setMasse(Convert.ToDouble(z_mass.Text));

                        if (z_radiusChanged)
                            orb.setRadius((float)Convert.ToDouble(z_radius.Text));

                        if (z_layoutChanged)
                            orb.setLayout(z_layout.Text);                        

                        orb.setV(v);
                        orb.setPosition(p);
                        if (!oldLinies.Checked)
                            orb.clearLastPositions();
                        orb.setCenter(z_center.SelectedIndex);
                    }
                    else
                    {
                        mw.delPlanet(orbList.SelectedIndex);
                        mw.add(z_name.Text, (float)Convert.ToDouble(z_radius.Text), Convert.ToDouble(z_mass.Text), p, v, z_layout.Text, z_center.SelectedIndex);
                    }
                }
                    //Ellipsenplanten
                else if (tabs.SelectedIndex == 1)
                {
                    double[] axis = { Convert.ToDouble(e_greataxis.Text), Convert.ToDouble(e_littleaxis.Text) };

                    double[] p = { Convert.ToDouble(e_x_position.Text), Convert.ToDouble(e_y_position.Text), 
                                   Convert.ToDouble(e_z_position.Text) };

                    if (((Orb)mw.getOrb(orbList.SelectedIndex)).getMethode().Equals("Ellipse"))
                    {
                        Orb_Ellipse orb = (Orb_Ellipse)mw.getOrb(orbList.SelectedIndex);

                        orb.setName(g_name.Text);

                        if (e_radiusChanged)
                            orb.setRadius((float)Convert.ToDouble(e_radius.Text));

                        if (e_layoutChanged)
                            orb.setLayout(e_layout.Text);

                        orb.setV(Convert.ToDouble(e_speed.Text));
                        orb.setAxis(axis);
                        if (!oldLinies.Checked)
                            orb.clearLastPositions();
                    }
                    else
                    {
                        mw.delPlanet(orbList.SelectedIndex);
                        mw.add(e_name.Text, (float)Convert.ToDouble(e_radius.Text), p, Convert.ToDouble(e_speed.Text), e_layout.Text, axis);
                    }
                }

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim editieren");
            }

        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void e_layout_SelectedIndexChanged(object sender, EventArgs e)
        {
            e_layoutChanged = true;
        }

        private void e_radius_TextChanged(object sender, EventArgs e)
        {
            e_radiusChanged = true;
        }

        private void g_layout_SelectedIndexChanged(object sender, EventArgs e)
        {
            g_layoutChanged = true;
        }

        private void g_radius_TextChanged(object sender, EventArgs e)
        {
            g_radiusChanged = true;
        }

        private void z_center_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void z_layout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


  
    }
}