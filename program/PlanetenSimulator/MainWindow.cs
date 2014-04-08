using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;


namespace PlanetenSimulator
{
    public partial class MainWindow : Form
    {
        //#############################
        //Variablen ###################
        //#############################

        private List<Orb> orbs = new List<Orb>();

        private Boolean stop = true;

        private Control control = new Control();


        //#############################
        //Settings ####################
        //#############################

        private double tick = 50;
        private string[] layouts = { "Rot", "Red",
                                     "Blau", "Blue",
                                     "Grün", "Green",
                                     "Sonne", "Yellow" };

        private int positionAbstand = 5;
        private float deep = 200f;

        // Event wird ausgelöst, wenn ein Childfenster kreiert wird.
        public EventHandler ChildCreated;
        Graphic graphic;

        public MainWindow()
        {
            InitializeComponent();
            this.ChildCreated += new System.EventHandler(subWindow);
            File.loadConfig("config.xml", this);

            graphic = new Graphic(this);
            try
            {
                graphic.InitializeDirectX();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            this.Dispose();
        }

        // Jetzt wirds spassig ;)
        // Berchnungen starten
        Thread[] threads;
        public bool isRunning = false;
        public void startCalc()
        {
            threads = new Thread[orbs.Count]; // Thread-Array
            for (int i = 0; i < orbs.Count; i++)
            {
                try
                {
                    threads[i] = new Thread(new ThreadStart(calcPositions)); // Threads werden erzeugt
                    threads[i].Start(); // Threads werden gestartet
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            playButton.Enabled = false;
            stopButton.Enabled = true;
            isRunning = true;
        }

        // Berechnungen anhalten
        public void stopCalc()
        {
            try
            {
                for (int i = 0; i < threads.Length; i++)
                    threads[i].Join();
            }
            catch (Exception)
            {
                for (int i = 0; i < orbs.Count; i++)
                    orbs[i].isThreated = false;
            }
            playButton.Enabled = true;
            stopButton.Enabled = false;
            isRunning = false;
        }

        // Berechnung
        private void calcPositions()
        {
            if (!stop)
            {
                List<Orb>.Enumerator o = orbs.GetEnumerator();

                while (o.MoveNext())
                {
                    Orb orb = (Orb)o.Current;
                    if (!orb.isThreated)
                    {
                        orb.isThreated = true;
                        bool delete = false;
                        while (!stop && !delete)
                        {
                            try
                            {
                                if (orb.getDelete())
                                {
                                    delete = true;
                                    delPlanet(orb);
                                }
                                else
                                {
                                    orb.nextPositon(orbs);
                                    Thread.Sleep((int)(100 * tick));
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Fehler bei calcPosition");
                            }
                        }
                        if(!delete)
                            orb.isThreated = false;

                        break;
                    }
                }
            }
        }

        //Planet hinzufügen (Graviation)
        public void add(string name, float radius, double masse, double[] position, double[] v, string layout)
        {
            stopCalc();
            Orb_Gravitation orb = new Orb_Gravitation(name, radius, masse, position, v, layout, this);
            //zur PlanetenListe hinzufügen (Objekt)
            orbs.Add(orb);

        }
        //Planet hinzufügen (Ellipse)
        public void add(string name, float radius, double[] position, double v, string layout, double[] axis)
        {
            stopCalc();
            Orb_Ellipse orb = new Orb_Ellipse(name, radius, position, v, layout, axis, this);
            //zur PlanetenListe hinzufügen (Objekt)
            orbs.Add(orb);

        }
        //Planet hinzufügen (EineSonne)
        public void add(string name, float radius, double masse, double[] position, double[] v, string layout, int center)
        {
            stopCalc();
            Orb_OneSun orb = new Orb_OneSun(name, radius, masse, position, v, layout, center, this);
            //zur PlanetenListe hinzufügen (Objekt)
            orbs.Add(orb);
        }

        public void setOrbs(List<Orb> newOrbs)
        {
            orbs = newOrbs;
        }

        // #################################
        // Menüleiste#######################
        //##################################


        //Datei#############################

        //Neu

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New neu = new New(this);
            newChild(neu);
            neu.Show();
        }

        public void delAll()
        {
            stop = true;
            stopCalc();
            //alle Planeten entfernen (neu)
            List<Orb>.Enumerator i = orbs.GetEnumerator();
            orbs.Clear();
        }

        //Speichern
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDialog.ShowDialog();
        }

        public void save()
        {
            saveDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            File.save(saveDialog.FileName, orbs);
        }
        //Laden
        public void load()
        {
            loadDialog.ShowDialog();
        }
        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            File.load(loadDialog.FileName, this);
        }

        // Das Programm beenden!
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            else if (keyData == Keys.F11)
                graphic.screenShot();
            else if (keyData == Keys.F1)
                stop = false;
            else if (keyData == Keys.F2)
                stop = true;
            else if (keyData == Keys.LControlKey && keyData == Keys.S)
                save();
            else
            {
                control.updateEvent(ref msg, keyData); ;
                graphic.setCameraPos(control.getPos(graphic.getCameraPos()));
                graphic.setCameraTarget(control.getTarget(graphic.getCameraTarget()));
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Info ########################

        //Über

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            newChild(about);
            about.Show();
        }

        //Planeten #########################

        //hinzufügen

        private void hinzufgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrb addPlanet = new AddOrb(this);
            newChild(addPlanet);
            addPlanet.Show();
        }
        //bearbeiten
        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrb editPlanet = new EditOrb(this);
            newChild(editPlanet);
            editPlanet.Show();
        }
        //entfernen
        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelOrb delPlanet = new DelOrb(this);
            newChild(delPlanet);
            delPlanet.Show();
        }

        public void delPlanet(int n)
        {//Körper n entfernen (Mesh und Obj)
            orbs.RemoveAt(n);
        }
        public void delPlanet(Orb planet)
        {//Körper n entfernen (Mesh und Obj)
            orbs.Remove(planet);
        }
        //anhalten
        private void playButton_Click(object sender, EventArgs e)
        {
            stop = false;
        }
        //start
        private void stopButton_Click(object sender, EventArgs e)
        {
            stop = true;
        }
        //start/stopp
        private void startPauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop = !stop;
        }
        // Screenshot
        private void screen_Click(object sender, EventArgs e)
        {
            graphic.screenShot();
        }

        //####################################
        //Symbolleiste unten##################
        //####################################



        //Bei Klick unten auf die Liste

        private void planetenDropDown_Click(object sender, EventArgs e)
        {
            this.planetenDropDown.DropDownItems.Clear();
            System.Windows.Forms.ToolStripItem[] dropDownPlaneten = new ToolStripItem[orbs.Count];
            System.Windows.Forms.ToolStripMenuItem dropDownPlanet;

            List<Orb>.Enumerator i = orbs.GetEnumerator();
            int j = 0;
            while (i.MoveNext())
            {
                dropDownPlanet = new System.Windows.Forms.ToolStripMenuItem();
                dropDownPlanet.Name = "dropDownPlanet";
                dropDownPlanet.Size = new System.Drawing.Size(152, 22);
                dropDownPlanet.Text = ((Orb)i.Current).getName();
                dropDownPlanet.Click += new System.EventHandler(this.dropDownPlanet_Click);

                dropDownPlaneten[j] = dropDownPlanet;
                j++;
            }

            if (dropDownPlaneten.Length > 0)
                this.planetenDropDown.DropDownItems.AddRange(dropDownPlaneten);


        }
        //Bei Klick auf einen Planeten in der Liste
        private void dropDownPlanet_Click(object sender, EventArgs e)
        {
            Boolean finish = false;

            List<Orb>.Enumerator i = orbs.GetEnumerator();
            while (i.MoveNext() && !finish)
            {
                Orb orb = (Orb)i.Current;
                if (orb.getName().Equals(((ToolStripMenuItem)sender).Text))
                {
                    this.nameLabel.Text = "Name: " + orb.getName();
                    this.radiusLabel.Text = "Radius: " + orb.getRadius().ToString();
                    this.positionLabel.Text = "Positon: " + orb.getPosition()[0].ToString() + "|" +
                                                            orb.getPosition()[1].ToString() + "|" +
                                                            orb.getPosition()[2].ToString();

                    if (orb is Orb_Gravitation)
                    {
                        Orb_Gravitation sorb = (Orb_Gravitation)orb;
                        this.vLabel.Text = "Geschwindigkeit: " + sorb.getV()[0].ToString() + "|" +
                                                                 sorb.getV()[1].ToString() + "|" +
                                                                 sorb.getV()[2].ToString();
                    }
                    else if (orb.getMethode() == "Ellipse")
                    {
                        Orb_Ellipse sorb = (Orb_Ellipse)orb;
                        this.vLabel.Text = "Geschwindigkeit: " + sorb.getV().ToString();
                    }
                    else if (orb.getMethode() == "OneSun")
                    {
                        Orb_OneSun sorb = (Orb_OneSun)orb;
                        this.vLabel.Text = "Geschwindigkeit: " + sorb.getV()[0].ToString() + "|" +
                                                                 sorb.getV()[1].ToString() + "|" +
                                                                 sorb.getV()[2].ToString();
                    }

                    finish = true;
                }
            }
        }

        //####################################
        //Sonstiges###########################
        //####################################

        public List<Orb> getOrbs()
        {
            return orbs;
        }

        public Orb getOrb(int index)
        {
            return orbs[index];
        }

        public Device getDevice()
        {
            return graphic.getDevice();
        }

        public double getTick()
        {
            return tick;
        }

        public void setTick(double tick)
        {
            this.tick = tick;
        }

        public string[] getLayouts()
        {
            return layouts;
        }
        public void setLayouts(string[] layouts)
        {
            this.layouts = layouts;
        }

        public int getPositionAbstand()
        {
            return positionAbstand;
        }
        public void setPositionAbstand(int abstand)
        {
            this.positionAbstand = abstand;
        }

        private void methodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options option = new Options(this);
            newChild(option);
            option.Show();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            newChild(help);
            help.Show();
        }

        // Wenn das Fenster beendet wird.
        private void exitForm(object sender, CancelEventArgs e)
        {
            stop = true;

            if (orbs.Count > 0)
            {
                DialogResult box = MessageBox.Show("Möchten Sie ihr aktuelles System speichern?",
                                                   "Schließen",
                                                   MessageBoxButtons.YesNoCancel);
                if (box == DialogResult.Yes)
                {
                    save();
                    e.Cancel = false;
                }
                else if (box == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }

        private void cleanVariables()
        {
            delAll();
        }
        private void subWindow(object sender, EventArgs e)
        {
            stop = true;
        }
        private void windowSizeChanged(object sender, EventArgs e)
        {
            if (child != null && !child.Disposing && !child.IsDisposed)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    stop = true;
                    child.Visible = false;
                }
                else
                    child.Visible = true;
            }
        }

        // Subfenster mit Event
        public Form child;
        public void newChild(Form form)
        {
            child = form;
            if (this.ChildCreated != null)
            {
                ChildCreated.Invoke(form, null);
            }
        }

        public bool getStop()
        {
            return stop;
        }

        public bool getIsRunning()
        {
            return isRunning;
        }

        public float getDeep()
        {
            return deep;
        }
        public void setDeep(float deep)
        {
            this.deep = deep;
        }

        private void viewAngle90_Click(object sender, EventArgs e)
        {
            viewAngle45.Enabled = true;
            viewAngle90.Enabled = false;

            graphic.setViewAngle((float)Math.PI / 2.0f);
        }

        private void viewAngle45_Click(object sender, EventArgs e)
        {
            viewAngle45.Enabled = false;
            viewAngle90.Enabled = true;

            graphic.setViewAngle((float)Math.PI / 4.0f);
        }
    }
}