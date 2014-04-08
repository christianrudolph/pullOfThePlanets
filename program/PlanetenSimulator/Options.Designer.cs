namespace PlanetenSimulator
{
    partial class Options
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.berchnung = new System.Windows.Forms.TabPage();
            this.tick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grafik = new System.Windows.Forms.TabPage();
            this.deep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.abstand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.layouts = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.berchnung.SuspendLayout();
            this.grafik.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.berchnung);
            this.tabs.Controls.Add(this.grafik);
            this.tabs.Location = new System.Drawing.Point(-1, 4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(293, 224);
            this.tabs.TabIndex = 0;
            // 
            // berchnung
            // 
            this.berchnung.Controls.Add(this.tick);
            this.berchnung.Controls.Add(this.label2);
            this.berchnung.Location = new System.Drawing.Point(4, 22);
            this.berchnung.Name = "berchnung";
            this.berchnung.Padding = new System.Windows.Forms.Padding(3);
            this.berchnung.Size = new System.Drawing.Size(285, 198);
            this.berchnung.TabIndex = 0;
            this.berchnung.Text = "Berechnung";
            this.berchnung.UseVisualStyleBackColor = true;
            // 
            // tick
            // 
            this.tick.Location = new System.Drawing.Point(78, 21);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(121, 20);
            this.tick.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tickgröße";
            // 
            // grafik
            // 
            this.grafik.Controls.Add(this.deep);
            this.grafik.Controls.Add(this.label4);
            this.grafik.Controls.Add(this.abstand);
            this.grafik.Controls.Add(this.label6);
            this.grafik.Controls.Add(this.label3);
            this.grafik.Controls.Add(this.layouts);
            this.grafik.Location = new System.Drawing.Point(4, 22);
            this.grafik.Name = "grafik";
            this.grafik.Padding = new System.Windows.Forms.Padding(3);
            this.grafik.Size = new System.Drawing.Size(285, 198);
            this.grafik.TabIndex = 1;
            this.grafik.Text = "Grafik";
            this.grafik.UseVisualStyleBackColor = true;
            // 
            // deep
            // 
            this.deep.Location = new System.Drawing.Point(77, 125);
            this.deep.Name = "deep";
            this.deep.Size = new System.Drawing.Size(100, 20);
            this.deep.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiefe";
            // 
            // abstand
            // 
            this.abstand.Location = new System.Drawing.Point(77, 21);
            this.abstand.Name = "abstand";
            this.abstand.Size = new System.Drawing.Size(100, 20);
            this.abstand.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Abstand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Farben";
            // 
            // layouts
            // 
            this.layouts.Location = new System.Drawing.Point(77, 47);
            this.layouts.Multiline = true;
            this.layouts.Name = "layouts";
            this.layouts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.layouts.Size = new System.Drawing.Size(176, 71);
            this.layouts.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(124, 234);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 1;
            this.submit.Text = "Übernehmen";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(213, 234);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Abbrechen";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Optionen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Options_Load);
            this.tabs.ResumeLayout(false);
            this.berchnung.ResumeLayout(false);
            this.berchnung.PerformLayout();
            this.grafik.ResumeLayout(false);
            this.grafik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage berchnung;
        private System.Windows.Forms.TabPage grafik;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox tick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox layouts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox abstand;
        private System.Windows.Forms.TextBox deep;
        private System.Windows.Forms.Label label4;

    }
}