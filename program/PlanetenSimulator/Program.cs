using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlanetenSimulator
{
    static class Program
    {
        //Haupteinstiegspunkt
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // MainWindow initialisieren
            MainWindow mw = new MainWindow();

            // MainWindow läuft...
            while (!mw.IsDisposed) {}

            // Anwendung beenden
            Application.Exit();
        }
    }
}