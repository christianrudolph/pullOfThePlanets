namespace PlanetenSimulator
{
    partial class DelOrb
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
            this.orbList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orbList
            // 
            this.orbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orbList.FormattingEnabled = true;
            this.orbList.Location = new System.Drawing.Point(12, 29);
            this.orbList.Name = "orbList";
            this.orbList.Size = new System.Drawing.Size(183, 21);
            this.orbList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Himmelskörper";
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(49, 55);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(64, 23);
            this.del.TabIndex = 3;
            this.del.Text = "Löschen";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(119, 55);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Abbrechen";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // DelOrb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 86);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orbList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelOrb";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Himmelskörper löschen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DelOrb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orbList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button cancel;
    }
}