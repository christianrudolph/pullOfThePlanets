using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    public partial class Options : Form
    {
        private MainWindow mw;

        public Options(MainWindow mw)
        {
            this.mw = mw;
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            tick.Text = mw.getTick().ToString();

            //////////// Grafik
            layouts.Lines = mw.getLayouts();
            abstand.Text = mw.getPositionAbstand().ToString();
            deep.Text = mw.getDeep().ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            mw.setTick(Convert.ToDouble(tick.Text));
            mw.setLayouts(layouts.Lines);
            mw.setDeep((float)Convert.ToDouble(deep.Text));

            mw.setPositionAbstand(Convert.ToInt16(abstand.Text));

            File.saveConfig("config.xml", mw);

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}