using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    public partial class New : Form
    {
        MainWindow mw;
        public New(MainWindow mw)
        {
            this.mw = mw;
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            //alle Planeten entfernen (neu)
            mw.delAll();
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            mw.child = null;
        }
    }
}