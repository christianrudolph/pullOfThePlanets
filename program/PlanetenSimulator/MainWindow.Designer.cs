namespace PlanetenSimulator
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        
        protected override void Dispose(bool disposing)
        {
            //  Speicher der Variablen freigeben
            if (disposing)
            {
                cleanVariables();
            }
            // Speicher der Grafikelelmente
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.planetenDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.nameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.radiusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.positionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.playButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.screen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewAngle45 = new System.Windows.Forms.ToolStripButton();
            this.viewAngle90 = new System.Windows.Forms.ToolStripButton();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optonenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadDialog
            // 
            this.loadDialog.Filter = "Himmelskörper (*.xml)|*.xml|Alle Dateien (*.*)|*.*";
            this.loadDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "xml";
            this.saveDialog.Filter = "Himmelskörper (*.xml)|*.xml|Alle Dateien (*.*)|*.*";
            this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planetenDropDown,
            this.nameLabel,
            this.radiusLabel,
            this.positionLabel,
            this.vLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // planetenDropDown
            // 
            this.planetenDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.planetenDropDown.Image = ((System.Drawing.Image)(resources.GetObject("planetenDropDown.Image")));
            this.planetenDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.planetenDropDown.Name = "planetenDropDown";
            this.planetenDropDown.Size = new System.Drawing.Size(96, 20);
            this.planetenDropDown.Text = "Himmelskörper: ";
            this.planetenDropDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.planetenDropDown.Click += new System.EventHandler(this.planetenDropDown_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // radiusLabel
            // 
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // positionLabel
            // 
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // vLabel
            // 
            this.vLabel.Name = "vLabel";
            this.vLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playButton,
            this.stopButton,
            this.toolStripSeparator1,
            this.screen,
            this.toolStripSeparator2,
            this.viewAngle45,
            this.viewAngle90});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // playButton
            // 
            this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //this.playButton.Image = global::PlanetenSimulator.Properties.Resources.run;
            this.playButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(23, 22);
            this.playButton.Text = "Start (F1)";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Enabled = false;
            //this.stopButton.Image = global::PlanetenSimulator.Properties.Resources.stop;
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(23, 22);
            this.stopButton.Text = "Stop (F2)";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // screen
            // 
            this.screen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.screen.Image = ((System.Drawing.Image)(resources.GetObject("screen.Image")));
            this.screen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(23, 22);
            this.screen.Text = "Screenshot (F11)";
            this.screen.Click += new System.EventHandler(this.screen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // viewAngle45
            // 
            this.viewAngle45.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewAngle45.Enabled = false;
            this.viewAngle45.Image = ((System.Drawing.Image)(resources.GetObject("viewAngle45.Image")));
            this.viewAngle45.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewAngle45.Name = "viewAngle45";
            this.viewAngle45.Size = new System.Drawing.Size(28, 22);
            this.viewAngle45.Text = "45°";
            this.viewAngle45.ToolTipText = "Blickwinkel: 45°";
            this.viewAngle45.Click += new System.EventHandler(this.viewAngle45_Click);
            // 
            // viewAngle90
            // 
            this.viewAngle90.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewAngle90.Image = ((System.Drawing.Image)(resources.GetObject("viewAngle90.Image")));
            this.viewAngle90.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewAngle90.Name = "viewAngle90";
            this.viewAngle90.Size = new System.Drawing.Size(28, 22);
            this.viewAngle90.Text = "90°";
            this.viewAngle90.ToolTipText = "Blickwinkel: 90°";
            this.viewAngle90.Click += new System.EventHandler(this.viewAngle90_Click);
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.ladenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.beendenToolStripMenuItem.Text = "Beenden (Esc)";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufgenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.entfernenToolStripMenuItem,
            this.startPauseToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.toolStripMenuItem1.Text = "Himmelskörper";
            // 
            // hinzufgenToolStripMenuItem
            // 
            this.hinzufgenToolStripMenuItem.Name = "hinzufgenToolStripMenuItem";
            this.hinzufgenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.hinzufgenToolStripMenuItem.Text = "Hinzufügen";
            this.hinzufgenToolStripMenuItem.Click += new System.EventHandler(this.hinzufgenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // startPauseToolStripMenuItem
            // 
            this.startPauseToolStripMenuItem.Name = "startPauseToolStripMenuItem";
            this.startPauseToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.startPauseToolStripMenuItem.Text = "Start/Stop";
            this.startPauseToolStripMenuItem.Click += new System.EventHandler(this.startPauseToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.statistikToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // statistikToolStripMenuItem
            // 
            this.statistikToolStripMenuItem.Name = "statistikToolStripMenuItem";
            this.statistikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statistikToolStripMenuItem.Text = "Statistik";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.optonenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optonenToolStripMenuItem
            // 
            this.optonenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.methodeToolStripMenuItem});
            this.optonenToolStripMenuItem.Name = "optonenToolStripMenuItem";
            this.optonenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.optonenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // methodeToolStripMenuItem
            // 
            this.methodeToolStripMenuItem.Name = "methodeToolStripMenuItem";
            this.methodeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.methodeToolStripMenuItem.Text = "Optionen";
            this.methodeToolStripMenuItem.Click += new System.EventHandler(this.methodeToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 753);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "PlanetenSimulator";
            this.SizeChanged += new System.EventHandler(this.windowSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitForm);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog loadDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton planetenDropDown;
        private System.Windows.Forms.ToolStripStatusLabel nameLabel;
        private System.Windows.Forms.ToolStripStatusLabel radiusLabel;
        private System.Windows.Forms.ToolStripStatusLabel positionLabel;
        private System.Windows.Forms.ToolStripStatusLabel vLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton playButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hinzufgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optonenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton screen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton viewAngle45;
        private System.Windows.Forms.ToolStripButton viewAngle90;
    }
}

