namespace BloodBank
{
    partial class donor_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.donor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DNameInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.DName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DBirthDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DPhoneInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DBlood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.DCity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.DBloodInsert = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DSaveInsert = new Guna.UI2.WinForms.Guna2Button();
            this.DGenderInsert = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DCityInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.DBirthDateInsert = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.patient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.donor);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 82);
            this.panel1.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(1110, 9);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 29);
            this.label33.TabIndex = 67;
            this.label33.Text = "X";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(699, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "View Patients";
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.ForeColor = System.Drawing.Color.White;
            this.patient.Location = new System.Drawing.Point(566, 26);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(107, 29);
            this.patient.TabIndex = 4;
            this.patient.Text = "Patients";
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(359, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "View Donors";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // donor
            // 
            this.donor.AutoSize = true;
            this.donor.BackColor = System.Drawing.Color.DarkRed;
            this.donor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor.ForeColor = System.Drawing.Color.White;
            this.donor.Location = new System.Drawing.Point(226, 28);
            this.donor.Name = "donor";
            this.donor.Size = new System.Drawing.Size(84, 29);
            this.donor.TabIndex = 2;
            this.donor.Text = "Donor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 2;
            // 
            // DNameInsert
            // 
            this.DNameInsert.BorderColor = System.Drawing.Color.Red;
            this.DNameInsert.BorderThickness = 2;
            this.DNameInsert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DNameInsert.DefaultText = "";
            this.DNameInsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DNameInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DNameInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DNameInsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DNameInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DNameInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNameInsert.ForeColor = System.Drawing.Color.Red;
            this.DNameInsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DNameInsert.Location = new System.Drawing.Point(135, 168);
            this.DNameInsert.Margin = new System.Windows.Forms.Padding(4);
            this.DNameInsert.Name = "DNameInsert";
            this.DNameInsert.PasswordChar = '\0';
            this.DNameInsert.PlaceholderText = "";
            this.DNameInsert.SelectedText = "";
            this.DNameInsert.Size = new System.Drawing.Size(262, 34);
            this.DNameInsert.TabIndex = 3;
            // 
            // DName
            // 
            this.DName.BackColor = System.Drawing.Color.Transparent;
            this.DName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DName.ForeColor = System.Drawing.Color.Firebrick;
            this.DName.Location = new System.Drawing.Point(135, 129);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(79, 33);
            this.DName.TabIndex = 4;
            this.DName.Text = "Name";
            // 
            // DBirthDate
            // 
            this.DBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.DBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBirthDate.ForeColor = System.Drawing.Color.Firebrick;
            this.DBirthDate.Location = new System.Drawing.Point(743, 234);
            this.DBirthDate.Name = "DBirthDate";
            this.DBirthDate.Size = new System.Drawing.Size(126, 33);
            this.DBirthDate.TabIndex = 7;
            this.DBirthDate.Text = "BirthDate";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(979, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 5;
            // 
            // DGender
            // 
            this.DGender.BackColor = System.Drawing.Color.Transparent;
            this.DGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGender.ForeColor = System.Drawing.Color.Firebrick;
            this.DGender.Location = new System.Drawing.Point(484, 129);
            this.DGender.Name = "DGender";
            this.DGender.Size = new System.Drawing.Size(99, 33);
            this.DGender.TabIndex = 10;
            this.DGender.Text = "Gender";
            this.DGender.Click += new System.EventHandler(this.DGender_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(504, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DPhone
            // 
            this.DPhone.BackColor = System.Drawing.Color.Transparent;
            this.DPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPhone.ForeColor = System.Drawing.Color.Firebrick;
            this.DPhone.Location = new System.Drawing.Point(135, 234);
            this.DPhone.Name = "DPhone";
            this.DPhone.Size = new System.Drawing.Size(86, 33);
            this.DPhone.TabIndex = 13;
            this.DPhone.Text = "Phone ";
            // 
            // DPhoneInsert
            // 
            this.DPhoneInsert.BorderColor = System.Drawing.Color.Red;
            this.DPhoneInsert.BorderThickness = 2;
            this.DPhoneInsert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DPhoneInsert.DefaultText = "";
            this.DPhoneInsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DPhoneInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DPhoneInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DPhoneInsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DPhoneInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DPhoneInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.DPhoneInsert.ForeColor = System.Drawing.Color.Red;
            this.DPhoneInsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DPhoneInsert.Location = new System.Drawing.Point(135, 274);
            this.DPhoneInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DPhoneInsert.Name = "DPhoneInsert";
            this.DPhoneInsert.PasswordChar = '\0';
            this.DPhoneInsert.PlaceholderText = "";
            this.DPhoneInsert.SelectedText = "";
            this.DPhoneInsert.Size = new System.Drawing.Size(262, 36);
            this.DPhoneInsert.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 273);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(0, 20);
            this.textBox4.TabIndex = 11;
            // 
            // DBlood
            // 
            this.DBlood.BackColor = System.Drawing.Color.Transparent;
            this.DBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBlood.ForeColor = System.Drawing.Color.Firebrick;
            this.DBlood.Location = new System.Drawing.Point(479, 234);
            this.DBlood.Name = "DBlood";
            this.DBlood.Size = new System.Drawing.Size(150, 33);
            this.DBlood.TabIndex = 16;
            this.DBlood.Text = "Blood Type";
            this.DBlood.Click += new System.EventHandler(this.DBlood_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(499, 273);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // DCity
            // 
            this.DCity.BackColor = System.Drawing.Color.Transparent;
            this.DCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCity.ForeColor = System.Drawing.Color.Firebrick;
            this.DCity.Location = new System.Drawing.Point(743, 129);
            this.DCity.Name = "DCity";
            this.DCity.Size = new System.Drawing.Size(55, 33);
            this.DCity.TabIndex = 19;
            this.DCity.Text = "City ";
            // 
            // DBloodInsert
            // 
            this.DBloodInsert.BackColor = System.Drawing.Color.Transparent;
            this.DBloodInsert.BorderColor = System.Drawing.Color.Red;
            this.DBloodInsert.BorderThickness = 2;
            this.DBloodInsert.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DBloodInsert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DBloodInsert.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DBloodInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DBloodInsert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DBloodInsert.ForeColor = System.Drawing.Color.Red;
            this.DBloodInsert.ItemHeight = 30;
            this.DBloodInsert.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.DBloodInsert.Location = new System.Drawing.Point(484, 273);
            this.DBloodInsert.Name = "DBloodInsert";
            this.DBloodInsert.Size = new System.Drawing.Size(188, 36);
            this.DBloodInsert.TabIndex = 20;
            this.DBloodInsert.SelectedIndexChanged += new System.EventHandler(this.DBloodInsert_SelectedIndexChanged);
            // 
            // DSaveInsert
            // 
            this.DSaveInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DSaveInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DSaveInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DSaveInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DSaveInsert.FillColor = System.Drawing.Color.Red;
            this.DSaveInsert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSaveInsert.ForeColor = System.Drawing.Color.White;
            this.DSaveInsert.Location = new System.Drawing.Point(492, 549);
            this.DSaveInsert.Name = "DSaveInsert";
            this.DSaveInsert.Size = new System.Drawing.Size(180, 45);
            this.DSaveInsert.TabIndex = 21;
            this.DSaveInsert.Text = "Save";
            this.DSaveInsert.Click += new System.EventHandler(this.DSaveInsert_Click);
            // 
            // DGenderInsert
            // 
            this.DGenderInsert.BackColor = System.Drawing.Color.Transparent;
            this.DGenderInsert.BorderColor = System.Drawing.Color.Red;
            this.DGenderInsert.BorderThickness = 2;
            this.DGenderInsert.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DGenderInsert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DGenderInsert.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DGenderInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DGenderInsert.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.DGenderInsert.ForeColor = System.Drawing.Color.Red;
            this.DGenderInsert.ItemHeight = 30;
            this.DGenderInsert.Items.AddRange(new object[] {
            "Female ",
            "Male "});
            this.DGenderInsert.Location = new System.Drawing.Point(484, 168);
            this.DGenderInsert.Name = "DGenderInsert";
            this.DGenderInsert.Size = new System.Drawing.Size(188, 36);
            this.DGenderInsert.TabIndex = 41;
            this.DGenderInsert.SelectedIndexChanged += new System.EventHandler(this.DGenderInsert_SelectedIndexChanged);
            // 
            // DCityInsert
            // 
            this.DCityInsert.BorderColor = System.Drawing.Color.Red;
            this.DCityInsert.BorderThickness = 2;
            this.DCityInsert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DCityInsert.DefaultText = "";
            this.DCityInsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DCityInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DCityInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DCityInsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DCityInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DCityInsert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DCityInsert.ForeColor = System.Drawing.Color.Red;
            this.DCityInsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DCityInsert.Location = new System.Drawing.Point(743, 168);
            this.DCityInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DCityInsert.Name = "DCityInsert";
            this.DCityInsert.PasswordChar = '\0';
            this.DCityInsert.PlaceholderText = "";
            this.DCityInsert.SelectedText = "";
            this.DCityInsert.Size = new System.Drawing.Size(219, 36);
            this.DCityInsert.TabIndex = 42;
            // 
            // DBirthDateInsert
            // 
            this.DBirthDateInsert.Checked = true;
            this.DBirthDateInsert.FillColor = System.Drawing.Color.Red;
            this.DBirthDateInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBirthDateInsert.ForeColor = System.Drawing.Color.White;
            this.DBirthDateInsert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DBirthDateInsert.Location = new System.Drawing.Point(743, 273);
            this.DBirthDateInsert.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DBirthDateInsert.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DBirthDateInsert.Name = "DBirthDateInsert";
            this.DBirthDateInsert.Size = new System.Drawing.Size(219, 48);
            this.DBirthDateInsert.TabIndex = 52;
            this.DBirthDateInsert.Value = new System.DateTime(2022, 5, 24, 13, 19, 47, 642);
            this.DBirthDateInsert.ValueChanged += new System.EventHandler(this.PBirthDateInsert_ValueChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BloodBank.Properties.Resources.blood_donation__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(513, 408);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(130, 135);
            this.guna2PictureBox1.TabIndex = 53;
            this.guna2PictureBox1.TabStop = false;
            // 
            // donor_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 656);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.DBirthDateInsert);
            this.Controls.Add(this.DCityInsert);
            this.Controls.Add(this.DGenderInsert);
            this.Controls.Add(this.DSaveInsert);
            this.Controls.Add(this.DBloodInsert);
            this.Controls.Add(this.DCity);
            this.Controls.Add(this.DBlood);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.DPhone);
            this.Controls.Add(this.DPhoneInsert);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.DGender);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DBirthDate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.DNameInsert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "donor_page";
            this.Text = "donor_page";
            this.Load += new System.EventHandler(this.donor_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label donor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox DNameInsert;
        private Guna.UI2.WinForms.Guna2HtmlLabel DName;
        private Guna.UI2.WinForms.Guna2HtmlLabel DBirthDate;
        private System.Windows.Forms.TextBox textBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel DGender;
        private System.Windows.Forms.TextBox textBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel DPhone;
        private Guna.UI2.WinForms.Guna2TextBox DPhoneInsert;
        private System.Windows.Forms.TextBox textBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel DBlood;
        private System.Windows.Forms.TextBox textBox5;
        private Guna.UI2.WinForms.Guna2HtmlLabel DCity;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ComboBox DBloodInsert;
        private Guna.UI2.WinForms.Guna2Button DSaveInsert;
        private Guna.UI2.WinForms.Guna2ComboBox DGenderInsert;
        private Guna.UI2.WinForms.Guna2TextBox DCityInsert;
        private Guna.UI2.WinForms.Guna2DateTimePicker DBirthDateInsert;
        private System.Windows.Forms.Label label33;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}