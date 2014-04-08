using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace PlanetenSimulator
{
    public partial class DelOrb : Form
    {
        private MainWindow mw;
        public DelOrb(MainWindow mw)
        {
            this.mw = mw;
            InitializeComponent();
        }

        private void DelOrb_Load(object sender, EventArgs e)
        {
            //Combobox initialisieren
            List<Orb>.Enumerator i = mw.getOrbs().GetEnumerator();
            while (i.MoveNext())
            {
                orbList.Items.Add(((Orb)i.Current).getName());
            }

            // 1. Element ausw�hlen
            if (orbList.Items.Count > 0)
                orbList.SelectedItem = orbList.Items[0];
        }

        private void del_Click(object sender, EventArgs e) //Planet entfernen
        {
            try
            {//entfernen
                mw.delPlanet(orbList.SelectedIndex);

                //Fenster schlie�en
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim L�schen.");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}