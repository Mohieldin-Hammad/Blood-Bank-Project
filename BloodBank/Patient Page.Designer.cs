namespace BloodBank
{
    partial class Patient_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PBloodInsert = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PCity_text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PCityInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.PBlood_text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PPhone_text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PPhoneInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PGender_text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PBD_text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PName_text = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PNameInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PSaveInsert = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.PGenderInsert = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PBirthDateInsert = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ptlabel = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.donor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBloodInsert
            // 
            this.PBloodInsert.BackColor = System.Drawing.Color.Transparent;
            this.PBloodInsert.BorderColor = System.Drawing.Color.Red;
            this.PBloodInsert.BorderThickness = 2;
            this.PBloodInsert.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PBloodInsert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PBloodInsert.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PBloodInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PBloodInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PBloodInsert.ForeColor = System.Drawing.Color.Red;
            this.PBloodInsert.ItemHeight = 30;
            this.PBloodInsert.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.PBloodInsert.Location = new System.Drawing.Point(470, 272);
            this.PBloodInsert.Name = "PBloodInsert";
            this.PBloodInsert.Size = new System.Drawing.Size(202, 36);
            this.PBloodInsert.TabIndex = 38;
            this.PBloodInsert.SelectedIndexChanged += new System.EventHandler(this.ptblood_SelectedIndexChanged);
            // 
            // PCity_text
            // 
            this.PCity_text.BackColor = System.Drawing.Color.Transparent;
            this.PCity_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCity_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PCity_text.Location = new System.Drawing.Point(730, 127);
            this.PCity_text.Name = "PCity_text";
            this.PCity_text.Size = new System.Drawing.Size(55, 33);
            this.PCity_text.TabIndex = 37;
            this.PCity_text.Text = "City";
            // 
            // PCityInsert
            // 
            this.PCityInsert.BorderColor = System.Drawing.Color.Red;
            this.PCityInsert.BorderThickness = 2;
            this.PCityInsert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PCityInsert.DefaultText = "";
            this.PCityInsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PCityInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PCityInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PCityInsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PCityInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PCityInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PCityInsert.ForeColor = System.Drawing.Color.Red;
            this.PCityInsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PCityInsert.Location = new System.Drawing.Point(730, 166);
            this.PCityInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PCityInsert.Name = "PCityInsert";
            this.PCityInsert.PasswordChar = '\0';
            this.PCityInsert.PlaceholderText = "";
            this.PCityInsert.SelectedText = "";
            this.PCityInsert.Size = new System.Drawing.Size(219, 37);
            this.PCityInsert.TabIndex = 36;
            // 
            // PBlood_text
            // 
            this.PBlood_text.BackColor = System.Drawing.Color.Transparent;
            this.PBlood_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBlood_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PBlood_text.Location = new System.Drawing.Point(470, 233);
            this.PBlood_text.Name = "PBlood_text";
            this.PBlood_text.Size = new System.Drawing.Size(150, 33);
            this.PBlood_text.TabIndex = 34;
            this.PBlood_text.Text = "Blood Type";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(423, 269);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 20);
            this.textBox5.TabIndex = 33;
            // 
            // PPhone_text
            // 
            this.PPhone_text.BackColor = System.Drawing.Color.Transparent;
            this.PPhone_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPhone_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PPhone_text.Location = new System.Drawing.Point(137, 230);
            this.PPhone_text.Name = "PPhone_text";
            this.PPhone_text.Size = new System.Drawing.Size(86, 33);
            this.PPhone_text.TabIndex = 32;
            this.PPhone_text.Text = "Phone ";
            // 
            // PPhoneInsert
            // 
            this.PPhoneInsert.BorderColor = System.Drawing.Color.Red;
            this.PPhoneInsert.BorderThickness = 2;
            this.PPhoneInsert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PPhoneInsert.DefaultText = "";
            this.PPhoneInsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PPhoneInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PPhoneInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPhoneInsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPhoneInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPhoneInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PPhoneInsert.ForeColor = System.Drawing.Color.Red;
            this.PPhoneInsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPhoneInsert.Location = new System.Drawing.Point(139, 272);
            this.PPhoneInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PPhoneInsert.Name = "PPhoneInsert";
            this.PPhoneInsert.PasswordChar = '\0';
            this.PPhoneInsert.PlaceholderText = "";
            this.PPhoneInsert.SelectedText = "";
            this.PPhoneInsert.Size = new System.Drawing.Size(257, 36);
            this.PPhoneInsert.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(0, 20);
            this.textBox4.TabIndex = 30;
            // 
            // PGender_text
            // 
            this.PGender_text.BackColor = System.Drawing.Color.Transparent;
            this.PGender_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PGender_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PGender_text.Location = new System.Drawing.Point(470, 127);
            this.PGender_text.Name = "PGender_text";
            this.PGender_text.Size = new System.Drawing.Size(99, 33);
            this.PGender_text.TabIndex = 29;
            this.PGender_text.Text = "Gender";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(499, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 27;
            // 
            // PBD_text
            // 
            this.PBD_text.BackColor = System.Drawing.Color.Transparent;
            this.PBD_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBD_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PBD_text.Location = new System.Drawing.Point(732, 230);
            this.PBD_text.Name = "PBD_text";
            this.PBD_text.Size = new System.Drawing.Size(126, 33);
            this.PBD_text.TabIndex = 26;
            this.PBD_text.Text = "BirthDate";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(423, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 24;
            // 
            // PName_text
            // 
            this.PName_text.BackColor = System.Drawing.Color.Transparent;
            this.PName_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PName_text.Location = new System.Drawing.Point(137, 127);
            this.PName_text.Name = "PName_text";
            this.PName_text.Size = new System.Drawing.Size(79, 33);
            this.PName_text.TabIndex = 23;
            this.PName_text.Text = "Name";
            // 
            // PNameInsert
            // 
            this.PNameInsert.BorderColor = System.Drawing.Color.Red;
            this.PNameInsert.BorderThickness = 2;
            this.PNameInsert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNameInsert.DefaultText = "";
            this.PNameInsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNameInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNameInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNameInsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNameInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNameInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PNameInsert.ForeColor = System.Drawing.Color.Red;
            this.PNameInsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNameInsert.Location = new System.Drawing.Point(137, 167);
            this.PNameInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PNameInsert.Name = "PNameInsert";
            this.PNameInsert.PasswordChar = '\0';
            this.PNameInsert.PlaceholderText = "";
            this.PNameInsert.SelectedText = "";
            this.PNameInsert.Size = new System.Drawing.Size(257, 36);
            this.PNameInsert.TabIndex = 22;
            this.PNameInsert.TextChanged += new System.EventHandler(this.PNameInsert_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 21;
            // 
            // PSaveInsert
            // 
            this.PSaveInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PSaveInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PSaveInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PSaveInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PSaveInsert.FillColor = System.Drawing.Color.Red;
            this.PSaveInsert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSaveInsert.ForeColor = System.Drawing.Color.White;
            this.PSaveInsert.Location = new System.Drawing.Point(492, 549);
            this.PSaveInsert.Name = "PSaveInsert";
            this.PSaveInsert.Size = new System.Drawing.Size(180, 45);
            this.PSaveInsert.TabIndex = 39;
            this.PSaveInsert.Text = "Save";
            this.PSaveInsert.Click += new System.EventHandler(this.PSaveInsert_Click);
            // 
            // PGenderInsert
            // 
            this.PGenderInsert.BackColor = System.Drawing.Color.Transparent;
            this.PGenderInsert.BorderColor = System.Drawing.Color.Red;
            this.PGenderInsert.BorderThickness = 2;
            this.PGenderInsert.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PGenderInsert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PGenderInsert.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PGenderInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PGenderInsert.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.PGenderInsert.ForeColor = System.Drawing.Color.Red;
            this.PGenderInsert.ItemHeight = 30;
            this.PGenderInsert.Items.AddRange(new object[] {
            "Female ",
            "Male "});
            this.PGenderInsert.Location = new System.Drawing.Point(470, 167);
            this.PGenderInsert.Name = "PGenderInsert";
            this.PGenderInsert.Size = new System.Drawing.Size(202, 36);
            this.PGenderInsert.TabIndex = 40;
            // 
            // PBirthDateInsert
            // 
            this.PBirthDateInsert.Checked = true;
            this.PBirthDateInsert.FillColor = System.Drawing.Color.Red;
            this.PBirthDateInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBirthDateInsert.ForeColor = System.Drawing.Color.White;
            this.PBirthDateInsert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PBirthDateInsert.Location = new System.Drawing.Point(730, 269);
            this.PBirthDateInsert.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PBirthDateInsert.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PBirthDateInsert.Name = "PBirthDateInsert";
            this.PBirthDateInsert.Size = new System.Drawing.Size(219, 48);
            this.PBirthDateInsert.TabIndex = 53;
            this.PBirthDateInsert.Value = new System.DateTime(2022, 5, 24, 13, 19, 47, 642);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BloodBank.Properties.Resources.blood_donation__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(513, 408);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(130, 135);
            this.guna2PictureBox1.TabIndex = 54;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ptlabel);
            this.panel1.Controls.Add(this.patient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.donor);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 82);
            this.panel1.TabIndex = 55;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(1109, 9);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 29);
            this.label33.TabIndex = 9;
            this.label33.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dashboard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(899, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Blood Transfer";
            // 
            // ptlabel
            // 
            this.ptlabel.AutoSize = true;
            this.ptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptlabel.ForeColor = System.Drawing.Color.White;
            this.ptlabel.Location = new System.Drawing.Point(707, 26);
            this.ptlabel.Name = "ptlabel";
            this.ptlabel.Size = new System.Drawing.Size(171, 29);
            this.ptlabel.TabIndex = 5;
            this.ptlabel.Text = "View Patients";
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.ForeColor = System.Drawing.Color.White;
            this.patient.Location = new System.Drawing.Point(570, 28);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(107, 29);
            this.patient.TabIndex = 4;
            this.patient.Text = "Patients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(374, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "View Donors";
            // 
            // donor
            // 
            this.donor.AutoSize = true;
            this.donor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor.ForeColor = System.Drawing.Color.White;
            this.donor.Location = new System.Drawing.Point(230, 26);
            this.donor.Name = "donor";
            this.donor.Size = new System.Drawing.Size(84, 29);
            this.donor.TabIndex = 2;
            this.donor.Text = "Donor";
            // 
            // Patient_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.PBirthDateInsert);
            this.Controls.Add(this.PGenderInsert);
            this.Controls.Add(this.PSaveInsert);
            this.Controls.Add(this.PBloodInsert);
            this.Controls.Add(this.PCity_text);
            this.Controls.Add(this.PCityInsert);
            this.Controls.Add(this.PBlood_text);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.PPhone_text);
            this.Controls.Add(this.PPhoneInsert);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.PGender_text);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.PBD_text);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PName_text);
            this.Controls.Add(this.PNameInsert);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Page";
            this.Text = "Patient_Page";
            this.Load += new System.EventHandler(this.Patient_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox PBloodInsert;
        private Guna.UI2.WinForms.Guna2HtmlLabel PCity_text;
        private Guna.UI2.WinForms.Guna2TextBox PCityInsert;
        private Guna.UI2.WinForms.Guna2HtmlLabel PBlood_text;
        private System.Windows.Forms.TextBox textBox5;
        private Guna.UI2.WinForms.Guna2HtmlLabel PPhone_text;
        private Guna.UI2.WinForms.Guna2TextBox PPhoneInsert;
        private System.Windows.Forms.TextBox textBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel PGender_text;
        private System.Windows.Forms.TextBox textBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel PBD_text;
        private System.Windows.Forms.TextBox textBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel PName_text;
        private Guna.UI2.WinForms.Guna2TextBox PNameInsert;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button PSaveInsert;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ComboBox PGenderInsert;
        private Guna.UI2.WinForms.Guna2DateTimePicker PBirthDateInsert;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ptlabel;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label donor;
    }
}