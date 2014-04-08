namespace PlanetenSimulator
{
    partial class AddOrb
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
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.gravitation = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.g_layout = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.g_name = new System.Windows.Forms.TextBox();
            this.g_mass = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.g_x_position = new System.Windows.Forms.TextBox();
            this.g_y_position = new System.Windows.Forms.TextBox();
            this.g_z_position = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.g_radius = new System.Windows.Forms.TextBox();
            this.g_z_speed = new System.Windows.Forms.TextBox();
            this.g_x_speed = new System.Windows.Forms.TextBox();
            this.g_y_speed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ellipse = new System.Windows.Forms.TabPage();
            this.e_focus = new System.Windows.Forms.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.e_littleaxis = new System.Windows.Forms.TextBox();
            this.e_greataxis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e_layout = new System.Windows.Forms.ComboBox();
            this.e_speed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.e_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.e_radius = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.e_x_position = new System.Windows.Forms.TextBox();
            this.e_y_position = new System.Windows.Forms.TextBox();
            this.e_z_position = new System.Windows.Forms.TextBox();
            this.eineSonne = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.z_layout = new System.Windows.Forms.ComboBox();
            this.z_y_position = new System.Windows.Forms.TextBox();
            this.z_z_position = new System.Windows.Forms.TextBox();
            this.z_y_speed = new System.Windows.Forms.TextBox();
            this.z_z_speed = new System.Windows.Forms.TextBox();
            this.z_center = new System.Windows.Forms.ComboBox();
            this.z_x_speed = new System.Windows.Forms.TextBox();
            this.z_name = new System.Windows.Forms.TextBox();
            this.z_x_position = new System.Windows.Forms.TextBox();
            this.z_mass = new System.Windows.Forms.TextBox();
            this.z_radius = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.gravitation.SuspendLayout();
            this.ellipse.SuspendLayout();
            this.eineSonne.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(131, 287);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 20;
            this.add.Text = "Hinzufügen";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(212, 287);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 21;
            this.cancel.Text = "Abbrechen";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.gravitation);
            this.tabs.Controls.Add(this.ellipse);
            this.tabs.Controls.Add(this.eineSonne);
            this.tabs.Location = new System.Drawing.Point(0, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(287, 269);
            this.tabs.TabIndex = 22;
            // 
            // gravitation
            // 
            this.gravitation.Controls.Add(this.label19);
            this.gravitation.Controls.Add(this.label20);
            this.gravitation.Controls.Add(this.g_layout);
            this.gravitation.Controls.Add(this.label21);
            this.gravitation.Controls.Add(this.g_name);
            this.gravitation.Controls.Add(this.g_mass);
            this.gravitation.Controls.Add(this.label22);
            this.gravitation.Controls.Add(this.g_x_position);
            this.gravitation.Controls.Add(this.g_y_position);
            this.gravitation.Controls.Add(this.g_z_position);
            this.gravitation.Controls.Add(this.label6);
            this.gravitation.Controls.Add(this.label2);
            this.gravitation.Controls.Add(this.g_radius);
            this.gravitation.Controls.Add(this.g_z_speed);
            this.gravitation.Controls.Add(this.g_x_speed);
            this.gravitation.Controls.Add(this.g_y_speed);
            this.gravitation.Controls.Add(this.label9);
            this.gravitation.Location = new System.Drawing.Point(4, 22);
            this.gravitation.Name = "gravitation";
            this.gravitation.Padding = new System.Windows.Forms.Padding(3);
            this.gravitation.Size = new System.Drawing.Size(279, 243);
            this.gravitation.TabIndex = 0;
            this.gravitation.Text = "Gravitation";
            this.gravitation.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(50, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Layout";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(54, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Name";
            // 
            // g_layout
            // 
            this.g_layout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.g_layout.FormattingEnabled = true;
            this.g_layout.Location = new System.Drawing.Point(95, 139);
            this.g_layout.Name = "g_layout";
            this.g_layout.Size = new System.Drawing.Size(121, 21);
            this.g_layout.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(45, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "Position";
            // 
            // g_name
            // 
            this.g_name.Location = new System.Drawing.Point(95, 9);
            this.g_name.Name = "g_name";
            this.g_name.Size = new System.Drawing.Size(119, 20);
            this.g_name.TabIndex = 1;
            // 
            // g_mass
            // 
            this.g_mass.Location = new System.Drawing.Point(95, 35);
            this.g_mass.Name = "g_mass";
            this.g_mass.Size = new System.Drawing.Size(119, 20);
            this.g_mass.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(49, 116);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Radius";
            // 
            // g_x_position
            // 
            this.g_x_position.Location = new System.Drawing.Point(95, 87);
            this.g_x_position.Name = "g_x_position";
            this.g_x_position.Size = new System.Drawing.Size(56, 20);
            this.g_x_position.TabIndex = 6;
            // 
            // g_y_position
            // 
            this.g_y_position.Location = new System.Drawing.Point(154, 87);
            this.g_y_position.Name = "g_y_position";
            this.g_y_position.Size = new System.Drawing.Size(57, 20);
            this.g_y_position.TabIndex = 7;
            // 
            // g_z_position
            // 
            this.g_z_position.Location = new System.Drawing.Point(217, 87);
            this.g_z_position.Name = "g_z_position";
            this.g_z_position.Size = new System.Drawing.Size(58, 20);
            this.g_z_position.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masse";
            // 
            // g_radius
            // 
            this.g_radius.Location = new System.Drawing.Point(95, 113);
            this.g_radius.Name = "g_radius";
            this.g_radius.Size = new System.Drawing.Size(121, 20);
            this.g_radius.TabIndex = 9;
            // 
            // g_z_speed
            // 
            this.g_z_speed.Location = new System.Drawing.Point(217, 61);
            this.g_z_speed.Name = "g_z_speed";
            this.g_z_speed.Size = new System.Drawing.Size(58, 20);
            this.g_z_speed.TabIndex = 5;
            // 
            // g_x_speed
            // 
            this.g_x_speed.Location = new System.Drawing.Point(95, 61);
            this.g_x_speed.Name = "g_x_speed";
            this.g_x_speed.Size = new System.Drawing.Size(56, 20);
            this.g_x_speed.TabIndex = 3;
            // 
            // g_y_speed
            // 
            this.g_y_speed.Location = new System.Drawing.Point(154, 61);
            this.g_y_speed.Name = "g_y_speed";
            this.g_y_speed.Size = new System.Drawing.Size(57, 20);
            this.g_y_speed.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Geschindigkeit";
            // 
            // ellipse
            // 
            this.ellipse.Controls.Add(this.e_focus);
            this.ellipse.Controls.Add(this.label29);
            this.ellipse.Controls.Add(this.label4);
            this.ellipse.Controls.Add(this.label3);
            this.ellipse.Controls.Add(this.e_littleaxis);
            this.ellipse.Controls.Add(this.e_greataxis);
            this.ellipse.Controls.Add(this.label1);
            this.ellipse.Controls.Add(this.label5);
            this.ellipse.Controls.Add(this.e_layout);
            this.ellipse.Controls.Add(this.e_speed);
            this.ellipse.Controls.Add(this.label10);
            this.ellipse.Controls.Add(this.e_name);
            this.ellipse.Controls.Add(this.label12);
            this.ellipse.Controls.Add(this.e_radius);
            this.ellipse.Controls.Add(this.label11);
            this.ellipse.Controls.Add(this.e_x_position);
            this.ellipse.Controls.Add(this.e_y_position);
            this.ellipse.Controls.Add(this.e_z_position);
            this.ellipse.Location = new System.Drawing.Point(4, 22);
            this.ellipse.Name = "ellipse";
            this.ellipse.Padding = new System.Windows.Forms.Padding(3);
            this.ellipse.Size = new System.Drawing.Size(279, 243);
            this.ellipse.TabIndex = 1;
            this.ellipse.Text = "Ellipse";
            this.ellipse.UseVisualStyleBackColor = true;
            // 
            // e_focus
            // 
            this.e_focus.Location = new System.Drawing.Point(95, 193);
            this.e_focus.Name = "e_focus";
            this.e_focus.Size = new System.Drawing.Size(54, 20);
            this.e_focus.TabIndex = 34;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 196);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 13);
            this.label29.TabIndex = 33;
            this.label29.Text = "Brennpunkt (x)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kleine Halbachse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Große Halbachse";
            // 
            // e_littleaxis
            // 
            this.e_littleaxis.Location = new System.Drawing.Point(95, 140);
            this.e_littleaxis.Name = "e_littleaxis";
            this.e_littleaxis.Size = new System.Drawing.Size(119, 20);
            this.e_littleaxis.TabIndex = 8;
            // 
            // e_greataxis
            // 
            this.e_greataxis.Location = new System.Drawing.Point(95, 114);
            this.e_greataxis.Name = "e_greataxis";
            this.e_greataxis.Size = new System.Drawing.Size(119, 20);
            this.e_greataxis.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Layout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Name";
            // 
            // e_layout
            // 
            this.e_layout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_layout.FormattingEnabled = true;
            this.e_layout.Location = new System.Drawing.Point(95, 166);
            this.e_layout.Name = "e_layout";
            this.e_layout.Size = new System.Drawing.Size(121, 21);
            this.e_layout.TabIndex = 9;
            // 
            // e_speed
            // 
            this.e_speed.Location = new System.Drawing.Point(95, 61);
            this.e_speed.Name = "e_speed";
            this.e_speed.Size = new System.Drawing.Size(119, 20);
            this.e_speed.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Position";
            // 
            // e_name
            // 
            this.e_name.Location = new System.Drawing.Point(95, 9);
            this.e_name.Name = "e_name";
            this.e_name.Size = new System.Drawing.Size(119, 20);
            this.e_name.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Geschindigkeit";
            // 
            // e_radius
            // 
            this.e_radius.Location = new System.Drawing.Point(95, 87);
            this.e_radius.Name = "e_radius";
            this.e_radius.Size = new System.Drawing.Size(119, 20);
            this.e_radius.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Radius";
            // 
            // e_x_position
            // 
            this.e_x_position.Location = new System.Drawing.Point(95, 35);
            this.e_x_position.Name = "e_x_position";
            this.e_x_position.Size = new System.Drawing.Size(54, 20);
            this.e_x_position.TabIndex = 2;
            // 
            // e_y_position
            // 
            this.e_y_position.Location = new System.Drawing.Point(155, 35);
            this.e_y_position.Name = "e_y_position";
            this.e_y_position.Size = new System.Drawing.Size(57, 20);
            this.e_y_position.TabIndex = 3;
            // 
            // e_z_position
            // 
            this.e_z_position.Location = new System.Drawing.Point(218, 35);
            this.e_z_position.Name = "e_z_position";
            this.e_z_position.Size = new System.Drawing.Size(58, 20);
            this.e_z_position.TabIndex = 4;
            // 
            // eineSonne
            // 
            this.eineSonne.Controls.Add(this.label28);
            this.eineSonne.Controls.Add(this.label27);
            this.eineSonne.Controls.Add(this.label26);
            this.eineSonne.Controls.Add(this.label25);
            this.eineSonne.Controls.Add(this.label24);
            this.eineSonne.Controls.Add(this.label23);
            this.eineSonne.Controls.Add(this.label18);
            this.eineSonne.Controls.Add(this.z_layout);
            this.eineSonne.Controls.Add(this.z_y_position);
            this.eineSonne.Controls.Add(this.z_z_position);
            this.eineSonne.Controls.Add(this.z_y_speed);
            this.eineSonne.Controls.Add(this.z_z_speed);
            this.eineSonne.Controls.Add(this.z_center);
            this.eineSonne.Controls.Add(this.z_x_speed);
            this.eineSonne.Controls.Add(this.z_name);
            this.eineSonne.Controls.Add(this.z_x_position);
            this.eineSonne.Controls.Add(this.z_mass);
            this.eineSonne.Controls.Add(this.z_radius);
            this.eineSonne.Controls.Add(this.label17);
            this.eineSonne.Controls.Add(this.label16);
            this.eineSonne.Controls.Add(this.label15);
            this.eineSonne.Controls.Add(this.label14);
            this.eineSonne.Controls.Add(this.label13);
            this.eineSonne.Controls.Add(this.label8);
            this.eineSonne.Controls.Add(this.label7);
            this.eineSonne.Location = new System.Drawing.Point(4, 22);
            this.eineSonne.Name = "eineSonne";
            this.eineSonne.Padding = new System.Windows.Forms.Padding(3);
            this.eineSonne.Size = new System.Drawing.Size(279, 243);
            this.eineSonne.TabIndex = 2;
            this.eineSonne.Text = "Ein Gravitationszentrum";
            this.eineSonne.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(45, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 18;
            this.label28.Text = "Position";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(49, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Radius";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(50, 141);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "Layout";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Geschwindigkeit";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(51, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Masse";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(43, 167);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 13;
            this.label23.Text = "Zentrum";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Name";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // z_layout
            // 
            this.z_layout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.z_layout.FormattingEnabled = true;
            this.z_layout.Location = new System.Drawing.Point(95, 138);
            this.z_layout.Name = "z_layout";
            this.z_layout.Size = new System.Drawing.Size(121, 21);
            this.z_layout.TabIndex = 10;
            // 
            // z_y_position
            // 
            this.z_y_position.Location = new System.Drawing.Point(151, 86);
            this.z_y_position.Name = "z_y_position";
            this.z_y_position.Size = new System.Drawing.Size(62, 20);
            this.z_y_position.TabIndex = 7;
            // 
            // z_z_position
            // 
            this.z_z_position.Location = new System.Drawing.Point(219, 86);
            this.z_z_position.Name = "z_z_position";
            this.z_z_position.Size = new System.Drawing.Size(52, 20);
            this.z_z_position.TabIndex = 8;
            // 
            // z_y_speed
            // 
            this.z_y_speed.Location = new System.Drawing.Point(151, 60);
            this.z_y_speed.Name = "z_y_speed";
            this.z_y_speed.Size = new System.Drawing.Size(62, 20);
            this.z_y_speed.TabIndex = 4;
            // 
            // z_z_speed
            // 
            this.z_z_speed.Location = new System.Drawing.Point(219, 60);
            this.z_z_speed.Name = "z_z_speed";
            this.z_z_speed.Size = new System.Drawing.Size(52, 20);
            this.z_z_speed.TabIndex = 5;
            // 
            // z_center
            // 
            this.z_center.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.z_center.FormattingEnabled = true;
            this.z_center.Location = new System.Drawing.Point(95, 164);
            this.z_center.Name = "z_center";
            this.z_center.Size = new System.Drawing.Size(121, 21);
            this.z_center.TabIndex = 11;
            // 
            // z_x_speed
            // 
            this.z_x_speed.Location = new System.Drawing.Point(95, 60);
            this.z_x_speed.Name = "z_x_speed";
            this.z_x_speed.Size = new System.Drawing.Size(50, 20);
            this.z_x_speed.TabIndex = 3;
            // 
            // z_name
            // 
            this.z_name.Location = new System.Drawing.Point(95, 9);
            this.z_name.Name = "z_name";
            this.z_name.Size = new System.Drawing.Size(121, 20);
            this.z_name.TabIndex = 1;
            // 
            // z_x_position
            // 
            this.z_x_position.Location = new System.Drawing.Point(95, 86);
            this.z_x_position.Name = "z_x_position";
            this.z_x_position.Size = new System.Drawing.Size(50, 20);
            this.z_x_position.TabIndex = 6;
            // 
            // z_mass
            // 
            this.z_mass.Location = new System.Drawing.Point(95, 34);
            this.z_mass.Name = "z_mass";
            this.z_mass.Size = new System.Drawing.Size(121, 20);
            this.z_mass.TabIndex = 2;
            // 
            // z_radius
            // 
            this.z_radius.Location = new System.Drawing.Point(95, 112);
            this.z_radius.Name = "z_radius";
            this.z_radius.Size = new System.Drawing.Size(121, 20);
            this.z_radius.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 0;
            // 
            // AddOrb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 322);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrb";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Himmelskörper hinzufügen";
            this.Load += new System.EventHandler(this.AddOrb_Load);
            this.tabs.ResumeLayout(false);
            this.gravitation.ResumeLayout(false);
            this.gravitation.PerformLayout();
            this.ellipse.ResumeLayout(false);
            this.ellipse.PerformLayout();
            this.eineSonne.ResumeLayout(false);
            this.eineSonne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage gravitation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox g_layout;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox g_name;
        private System.Windows.Forms.TextBox g_mass;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox g_x_position;
        private System.Windows.Forms.TextBox g_y_position;
        private System.Windows.Forms.TextBox g_z_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox g_radius;
        private System.Windows.Forms.TextBox g_z_speed;
        private System.Windows.Forms.TextBox g_x_speed;
        private System.Windows.Forms.TextBox g_y_speed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage ellipse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox e_littleaxis;
        private System.Windows.Forms.TextBox e_greataxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox e_layout;
        private System.Windows.Forms.TextBox e_speed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox e_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox e_radius;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox e_x_position;
        private System.Windows.Forms.TextBox e_y_position;
        private System.Windows.Forms.TextBox e_z_position;
        private System.Windows.Forms.TabPage eineSonne;
        private System.Windows.Forms.ComboBox z_layout;
        private System.Windows.Forms.TextBox z_y_position;
        private System.Windows.Forms.TextBox z_z_position;
        private System.Windows.Forms.TextBox z_y_speed;
        private System.Windows.Forms.TextBox z_z_speed;
        private System.Windows.Forms.ComboBox z_center;
        private System.Windows.Forms.TextBox z_x_speed;
        private System.Windows.Forms.TextBox z_name;
        private System.Windows.Forms.TextBox z_x_position;
        private System.Windows.Forms.TextBox z_mass;
        private System.Windows.Forms.TextBox z_radius;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox e_focus;
        private System.Windows.Forms.Label label29;

    }
}