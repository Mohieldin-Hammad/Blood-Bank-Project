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
            this.Exit = new System.Windows.Forms.Label();
            this.DashBoard_Page = new System.Windows.Forms.Label();
            this.BloodTransfer_Page = new System.Windows.Forms.Label();
            this.ViewPatients_Page = new System.Windows.Forms.Label();
            this.Patients_page = new System.Windows.Forms.Label();
            this.ViewDonors_Page = new System.Windows.Forms.Label();
            this.Donor_Page = new System.Windows.Forms.Label();
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
            this.PBloodInsert.Location = new System.Drawing.Point(627, 335);
            this.PBloodInsert.Margin = new System.Windows.Forms.Padding(4);
            this.PBloodInsert.Name = "PBloodInsert";
            this.PBloodInsert.Size = new System.Drawing.Size(268, 36);
            this.PBloodInsert.TabIndex = 38;
            this.PBloodInsert.SelectedIndexChanged += new System.EventHandler(this.ptblood_SelectedIndexChanged);
            // 
            // PCity_text
            // 
            this.PCity_text.AutoSize = false;
            this.PCity_text.BackColor = System.Drawing.Color.Transparent;
            this.PCity_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCity_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PCity_text.Location = new System.Drawing.Point(973, 156);
            this.PCity_text.Margin = new System.Windows.Forms.Padding(4);
            this.PCity_text.Name = "PCity_text";
            this.PCity_text.Size = new System.Drawing.Size(111, 41);
            this.PCity_text.TabIndex = 37;
            this.PCity_text.Text = "City";
            this.PCity_text.Click += new System.EventHandler(this.PCity_text_Click);
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
            this.PCityInsert.Location = new System.Drawing.Point(973, 204);
            this.PCityInsert.Margin = new System.Windows.Forms.Padding(5);
            this.PCityInsert.Name = "PCityInsert";
            this.PCityInsert.PasswordChar = '\0';
            this.PCityInsert.PlaceholderText = "";
            this.PCityInsert.SelectedText = "";
            this.PCityInsert.Size = new System.Drawing.Size(292, 46);
            this.PCityInsert.TabIndex = 36;
            // 
            // PBlood_text
            // 
            this.PBlood_text.AutoSize = false;
            this.PBlood_text.BackColor = System.Drawing.Color.Transparent;
            this.PBlood_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBlood_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PBlood_text.Location = new System.Drawing.Point(627, 287);
            this.PBlood_text.Margin = new System.Windows.Forms.Padding(4);
            this.PBlood_text.Name = "PBlood_text";
            this.PBlood_text.Size = new System.Drawing.Size(231, 41);
            this.PBlood_text.TabIndex = 34;
            this.PBlood_text.Text = "Blood Type";
            this.PBlood_text.Click += new System.EventHandler(this.PBlood_text_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(564, 331);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 22);
            this.textBox5.TabIndex = 33;
            // 
            // PPhone_text
            // 
            this.PPhone_text.AutoSize = false;
            this.PPhone_text.BackColor = System.Drawing.Color.Transparent;
            this.PPhone_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPhone_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PPhone_text.Location = new System.Drawing.Point(183, 283);
            this.PPhone_text.Margin = new System.Windows.Forms.Padding(4);
            this.PPhone_text.Name = "PPhone_text";
            this.PPhone_text.Size = new System.Drawing.Size(152, 41);
            this.PPhone_text.TabIndex = 32;
            this.PPhone_text.Text = "Phone ";
            this.PPhone_text.Click += new System.EventHandler(this.PPhone_text_Click);
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
            this.PPhoneInsert.Location = new System.Drawing.Point(185, 335);
            this.PPhoneInsert.Margin = new System.Windows.Forms.Padding(5);
            this.PPhoneInsert.Name = "PPhoneInsert";
            this.PPhoneInsert.PasswordChar = '\0';
            this.PPhoneInsert.PlaceholderText = "";
            this.PPhoneInsert.SelectedText = "";
            this.PPhoneInsert.Size = new System.Drawing.Size(343, 44);
            this.PPhoneInsert.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 239);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(0, 22);
            this.textBox4.TabIndex = 30;
            // 
            // PGender_text
            // 
            this.PGender_text.AutoSize = false;
            this.PGender_text.BackColor = System.Drawing.Color.Transparent;
            this.PGender_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PGender_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PGender_text.Location = new System.Drawing.Point(627, 156);
            this.PGender_text.Margin = new System.Windows.Forms.Padding(4);
            this.PGender_text.Name = "PGender_text";
            this.PGender_text.Size = new System.Drawing.Size(167, 41);
            this.PGender_text.TabIndex = 29;
            this.PGender_text.Text = "Gender";
            this.PGender_text.Click += new System.EventHandler(this.PGender_text_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(665, 204);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 22);
            this.textBox3.TabIndex = 27;
            // 
            // PBD_text
            // 
            this.PBD_text.AutoSize = false;
            this.PBD_text.BackColor = System.Drawing.Color.Transparent;
            this.PBD_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBD_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PBD_text.Location = new System.Drawing.Point(976, 283);
            this.PBD_text.Margin = new System.Windows.Forms.Padding(4);
            this.PBD_text.Name = "PBD_text";
            this.PBD_text.Size = new System.Drawing.Size(199, 41);
            this.PBD_text.TabIndex = 26;
            this.PBD_text.Text = "BirthDate";
            this.PBD_text.Click += new System.EventHandler(this.PBD_text_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(564, 204);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 22);
            this.textBox2.TabIndex = 24;
            // 
            // PName_text
            // 
            this.PName_text.AutoSize = false;
            this.PName_text.BackColor = System.Drawing.Color.Transparent;
            this.PName_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName_text.ForeColor = System.Drawing.Color.Firebrick;
            this.PName_text.Location = new System.Drawing.Point(183, 156);
            this.PName_text.Margin = new System.Windows.Forms.Padding(4);
            this.PName_text.Name = "PName_text";
            this.PName_text.Size = new System.Drawing.Size(145, 41);
            this.PName_text.TabIndex = 23;
            this.PName_text.Text = "Name";
            this.PName_text.Click += new System.EventHandler(this.PName_text_Click);
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
            this.PNameInsert.Location = new System.Drawing.Point(183, 206);
            this.PNameInsert.Margin = new System.Windows.Forms.Padding(5);
            this.PNameInsert.Name = "PNameInsert";
            this.PNameInsert.PasswordChar = '\0';
            this.PNameInsert.PlaceholderText = "";
            this.PNameInsert.SelectedText = "";
            this.PNameInsert.Size = new System.Drawing.Size(343, 44);
            this.PNameInsert.TabIndex = 22;
            this.PNameInsert.TextChanged += new System.EventHandler(this.PNameInsert_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 204);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
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
            this.PSaveInsert.Location = new System.Drawing.Point(656, 676);
            this.PSaveInsert.Margin = new System.Windows.Forms.Padding(4);
            this.PSaveInsert.Name = "PSaveInsert";
            this.PSaveInsert.Size = new System.Drawing.Size(240, 55);
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
            "Male",
            "Female"});
            this.PGenderInsert.Location = new System.Drawing.Point(627, 206);
            this.PGenderInsert.Margin = new System.Windows.Forms.Padding(4);
            this.PGenderInsert.Name = "PGenderInsert";
            this.PGenderInsert.Size = new System.Drawing.Size(268, 36);
            this.PGenderInsert.TabIndex = 40;
            // 
            // PBirthDateInsert
            // 
            this.PBirthDateInsert.Checked = true;
            this.PBirthDateInsert.CustomFormat = "yyyy-MM-dd";
            this.PBirthDateInsert.FillColor = System.Drawing.Color.Red;
            this.PBirthDateInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBirthDateInsert.ForeColor = System.Drawing.Color.White;
            this.PBirthDateInsert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PBirthDateInsert.Location = new System.Drawing.Point(973, 331);
            this.PBirthDateInsert.Margin = new System.Windows.Forms.Padding(4);
            this.PBirthDateInsert.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PBirthDateInsert.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PBirthDateInsert.Name = "PBirthDateInsert";
            this.PBirthDateInsert.Size = new System.Drawing.Size(292, 59);
            this.PBirthDateInsert.TabIndex = 53;
            this.PBirthDateInsert.Value = new System.DateTime(2022, 5, 25, 23, 32, 14, 0);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BloodBank.Properties.Resources.blood_donation__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(684, 502);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(173, 166);
            this.guna2PictureBox1.TabIndex = 54;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.DashBoard_Page);
            this.panel1.Controls.Add(this.BloodTransfer_Page);
            this.panel1.Controls.Add(this.ViewPatients_Page);
            this.panel1.Controls.Add(this.Patients_page);
            this.panel1.Controls.Add(this.ViewDonors_Page);
            this.panel1.Controls.Add(this.Donor_Page);
            this.panel1.Location = new System.Drawing.Point(52, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1536, 101);
            this.panel1.TabIndex = 55;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1479, 11);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(37, 36);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DashBoard_Page
            // 
            this.DashBoard_Page.AutoSize = true;
            this.DashBoard_Page.BackColor = System.Drawing.Color.Red;
            this.DashBoard_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard_Page.ForeColor = System.Drawing.Color.White;
            this.DashBoard_Page.Location = new System.Drawing.Point(40, 34);
            this.DashBoard_Page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashBoard_Page.Name = "DashBoard_Page";
            this.DashBoard_Page.Size = new System.Drawing.Size(173, 36);
            this.DashBoard_Page.TabIndex = 8;
            this.DashBoard_Page.Text = "DashBoard";
            this.DashBoard_Page.Click += new System.EventHandler(this.DashBoard_Page_Click);
            // 
            // BloodTransfer_Page
            // 
            this.BloodTransfer_Page.AutoSize = true;
            this.BloodTransfer_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodTransfer_Page.ForeColor = System.Drawing.Color.White;
            this.BloodTransfer_Page.Location = new System.Drawing.Point(1199, 32);
            this.BloodTransfer_Page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodTransfer_Page.Name = "BloodTransfer_Page";
            this.BloodTransfer_Page.Size = new System.Drawing.Size(225, 36);
            this.BloodTransfer_Page.TabIndex = 7;
            this.BloodTransfer_Page.Text = "Blood Transfer";
            this.BloodTransfer_Page.Click += new System.EventHandler(this.BloodTransfer_Page_Click);
            // 
            // ViewPatients_Page
            // 
            this.ViewPatients_Page.AutoSize = true;
            this.ViewPatients_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatients_Page.ForeColor = System.Drawing.Color.White;
            this.ViewPatients_Page.Location = new System.Drawing.Point(943, 32);
            this.ViewPatients_Page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewPatients_Page.Name = "ViewPatients_Page";
            this.ViewPatients_Page.Size = new System.Drawing.Size(209, 36);
            this.ViewPatients_Page.TabIndex = 5;
            this.ViewPatients_Page.Text = "View Patients";
            this.ViewPatients_Page.Click += new System.EventHandler(this.ViewPatients_Page_Click);
            // 
            // Patients_page
            // 
            this.Patients_page.AutoSize = true;
            this.Patients_page.BackColor = System.Drawing.Color.Firebrick;
            this.Patients_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patients_page.ForeColor = System.Drawing.Color.White;
            this.Patients_page.Location = new System.Drawing.Point(760, 34);
            this.Patients_page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Patients_page.Name = "Patients_page";
            this.Patients_page.Size = new System.Drawing.Size(114, 36);
            this.Patients_page.TabIndex = 4;
            this.Patients_page.Text = "Patient";
            this.Patients_page.Click += new System.EventHandler(this.Patients_page_Click);
            // 
            // ViewDonors_Page
            // 
            this.ViewDonors_Page.AutoSize = true;
            this.ViewDonors_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDonors_Page.ForeColor = System.Drawing.Color.White;
            this.ViewDonors_Page.Location = new System.Drawing.Point(499, 32);
            this.ViewDonors_Page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewDonors_Page.Name = "ViewDonors_Page";
            this.ViewDonors_Page.Size = new System.Drawing.Size(197, 36);
            this.ViewDonors_Page.TabIndex = 3;
            this.ViewDonors_Page.Text = "View Donors";
            this.ViewDonors_Page.Click += new System.EventHandler(this.ViewDonors_Page_Click);
            // 
            // Donor_Page
            // 
            this.Donor_Page.AutoSize = true;
            this.Donor_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donor_Page.ForeColor = System.Drawing.Color.White;
            this.Donor_Page.Location = new System.Drawing.Point(307, 32);
            this.Donor_Page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Donor_Page.Name = "Donor_Page";
            this.Donor_Page.Size = new System.Drawing.Size(102, 36);
            this.Donor_Page.TabIndex = 2;
            this.Donor_Page.Text = "Donor";
            this.Donor_Page.Click += new System.EventHandler(this.Donor_Page_Click);
            // 
            // Patient_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 807);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Patient_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label DashBoard_Page;
        private System.Windows.Forms.Label BloodTransfer_Page;
        private System.Windows.Forms.Label ViewPatients_Page;
        private System.Windows.Forms.Label Patients_page;
        private System.Windows.Forms.Label ViewDonors_Page;
        private System.Windows.Forms.Label Donor_Page;
    }
}