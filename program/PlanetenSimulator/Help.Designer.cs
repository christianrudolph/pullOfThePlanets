namespace PlanetenSimulator
{
    partial class Help
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
            this.answer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.danke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(12, 81);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(420, 13);
            this.answer.TabIndex = 0;
            this.answer.Text = "Dieses Programm ist ein Programm. Bei Problemen benutzen Sie ihr Gehirn oder Goog" +
                "le:";
            this.answer.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 97);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(474, 319);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("http://www.google.de", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(188, 6);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(298, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bitte geben Sie Ihre Frage hier ein:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hilfe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Antwort:";
            // 
            // danke
            // 
            this.danke.AutoSize = true;
            this.danke.Location = new System.Drawing.Point(12, 423);
            this.danke.Name = "danke";
            this.danke.Size = new System.Drawing.Size(286, 13);
            this.danke.TabIndex = 9;
            this.danke.Text = "Für diese Antwort berechnen wir Ihnen 3,69$. Vielen Dank.";
            this.danke.Visible = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 463);
            this.Controls.Add(this.danke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hilfe";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label danke;
    }
}