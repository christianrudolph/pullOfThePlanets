using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answer.Visible = true;
            webBrowser1.Visible = true;
            Uri url = new Uri("http://www.google.de/search?hl=de&q=" + maskedTextBox1.Text + "&btnG=Google-Suche&meta=");
            webBrowser1.Url = url;
            danke.Text = "Für diese Antwort berechnen wir Ihnen " + maskedTextBox1.Text.Length * 0.13f + "$. Vielen Dank.";
            danke.Visible = true;
        }
    }
}