namespace BloodBank
{
    partial class view_donor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.VDBlood = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.VDName = new Guna.UI2.WinForms.Guna2TextBox();
            this.VDEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.DEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.DashBoard_Page = new System.Windows.Forms.Label();
            this.BloodTransfer_Page = new System.Windows.Forms.Label();
            this.ViewPatients_Page = new System.Windows.Forms.Label();
            this.Patients_page = new System.Windows.Forms.Label();
            this.ViewDonors_Page = new System.Windows.Forms.Label();
            this.Donor_Page = new System.Windows.Forms.Label();
            this.EditButton = new Guna.UI2.WinForms.Guna2Button();
            this.DelButton = new Guna.UI2.WinForms.Guna2Button();
            this.VDBD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.VDGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DTshow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DCityInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.DCity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(467, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(512, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "Donor List";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 294);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1, 20);
            this.textBox4.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(345, 294);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1, 20);
            this.textBox5.TabIndex = 33;
            // 
            // VDBlood
            // 
            this.VDBlood.BackColor = System.Drawing.Color.Transparent;
            this.VDBlood.BorderColor = System.Drawing.Color.Red;
            this.VDBlood.BorderThickness = 2;
            this.VDBlood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.VDBlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VDBlood.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VDBlood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VDBlood.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.VDBlood.ForeColor = System.Drawing.Color.Red;
            this.VDBlood.ItemHeight = 30;
            this.VDBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.VDBlood.Location = new System.Drawing.Point(344, 123);
            this.VDBlood.Name = "VDBlood";
            this.VDBlood.Size = new System.Drawing.Size(158, 36);
            this.VDBlood.TabIndex = 67;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Firebrick;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(344, 95);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(139, 27);
            this.guna2HtmlLabel5.TabIndex = 66;
            this.guna2HtmlLabel5.Text = "Blood Type";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(188, 97);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(100, 27);
            this.guna2HtmlLabel3.TabIndex = 64;
            this.guna2HtmlLabel3.Text = "Gender";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(451, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1, 20);
            this.textBox3.TabIndex = 63;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Firebrick;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(32, 96);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(119, 27);
            this.guna2HtmlLabel1.TabIndex = 61;
            this.guna2HtmlLabel1.Text = "Name";
            // 
            // VDName
            // 
            this.VDName.BorderColor = System.Drawing.Color.Red;
            this.VDName.BorderThickness = 2;
            this.VDName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VDName.DefaultText = "";
            this.VDName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VDName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VDName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VDName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VDName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VDName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VDName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VDName.Location = new System.Drawing.Point(32, 123);
            this.VDName.Name = "VDName";
            this.VDName.PasswordChar = '\0';
            this.VDName.PlaceholderText = "";
            this.VDName.SelectedText = "";
            this.VDName.Size = new System.Drawing.Size(148, 29);
            this.VDName.TabIndex = 60;
            // 
            // VDEmail
            // 
            this.VDEmail.BorderColor = System.Drawing.Color.Red;
            this.VDEmail.BorderThickness = 2;
            this.VDEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VDEmail.DefaultText = "";
            this.VDEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VDEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VDEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VDEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VDEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VDEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VDEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VDEmail.Location = new System.Drawing.Point(507, 123);
            this.VDEmail.Name = "VDEmail";
            this.VDEmail.PasswordChar = '\0';
            this.VDEmail.PlaceholderText = "";
            this.VDEmail.SelectedText = "";
            this.VDEmail.Size = new System.Drawing.Size(200, 29);
            this.VDEmail.TabIndex = 74;
            // 
            // DEmail
            // 
            this.DEmail.AutoSize = false;
            this.DEmail.BackColor = System.Drawing.Color.Transparent;
            this.DEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.DEmail.Location = new System.Drawing.Point(506, 97);
            this.DEmail.Name = "DEmail";
            this.DEmail.Size = new System.Drawing.Size(90, 27);
            this.DEmail.TabIndex = 73;
            this.DEmail.Text = "E-mail";
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
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 82);
            this.panel1.TabIndex = 75;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1109, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(31, 29);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DashBoard_Page
            // 
            this.DashBoard_Page.AutoSize = true;
            this.DashBoard_Page.BackColor = System.Drawing.Color.Transparent;
            this.DashBoard_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard_Page.ForeColor = System.Drawing.Color.White;
            this.DashBoard_Page.Location = new System.Drawing.Point(30, 28);
            this.DashBoard_Page.Name = "DashBoard_Page";
            this.DashBoard_Page.Size = new System.Drawing.Size(142, 29);
            this.DashBoard_Page.TabIndex = 8;
            this.DashBoard_Page.Text = "DashBoard";
            this.DashBoard_Page.Click += new System.EventHandler(this.DashBoard_Page_Click);
            // 
            // BloodTransfer_Page
            // 
            this.BloodTransfer_Page.AutoSize = true;
            this.BloodTransfer_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodTransfer_Page.ForeColor = System.Drawing.Color.White;
            this.BloodTransfer_Page.Location = new System.Drawing.Point(899, 26);
            this.BloodTransfer_Page.Name = "BloodTransfer_Page";
            this.BloodTransfer_Page.Size = new System.Drawing.Size(187, 29);
            this.BloodTransfer_Page.TabIndex = 7;
            this.BloodTransfer_Page.Text = "Blood Transfer";
            this.BloodTransfer_Page.Click += new System.EventHandler(this.BloodTransfer_Page_Click);
            // 
            // ViewPatients_Page
            // 
            this.ViewPatients_Page.AutoSize = true;
            this.ViewPatients_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatients_Page.ForeColor = System.Drawing.Color.White;
            this.ViewPatients_Page.Location = new System.Drawing.Point(707, 26);
            this.ViewPatients_Page.Name = "ViewPatients_Page";
            this.ViewPatients_Page.Size = new System.Drawing.Size(171, 29);
            this.ViewPatients_Page.TabIndex = 5;
            this.ViewPatients_Page.Text = "View Patients";
            this.ViewPatients_Page.Click += new System.EventHandler(this.ViewPatients_Page_Click);
            // 
            // Patients_page
            // 
            this.Patients_page.AutoSize = true;
            this.Patients_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patients_page.ForeColor = System.Drawing.Color.White;
            this.Patients_page.Location = new System.Drawing.Point(570, 28);
            this.Patients_page.Name = "Patients_page";
            this.Patients_page.Size = new System.Drawing.Size(107, 29);
            this.Patients_page.TabIndex = 4;
            this.Patients_page.Text = "Patients";
            this.Patients_page.Click += new System.EventHandler(this.Patients_page_Click);
            // 
            // ViewDonors_Page
            // 
            this.ViewDonors_Page.AutoSize = true;
            this.ViewDonors_Page.BackColor = System.Drawing.Color.DarkRed;
            this.ViewDonors_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDonors_Page.ForeColor = System.Drawing.Color.White;
            this.ViewDonors_Page.Location = new System.Drawing.Point(374, 26);
            this.ViewDonors_Page.Name = "ViewDonors_Page";
            this.ViewDonors_Page.Size = new System.Drawing.Size(161, 29);
            this.ViewDonors_Page.TabIndex = 3;
            this.ViewDonors_Page.Text = "View Donors";
            this.ViewDonors_Page.Click += new System.EventHandler(this.ViewDonors_Page_Click);
            // 
            // Donor_Page
            // 
            this.Donor_Page.AutoSize = true;
            this.Donor_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donor_Page.ForeColor = System.Drawing.Color.White;
            this.Donor_Page.Location = new System.Drawing.Point(230, 26);
            this.Donor_Page.Name = "Donor_Page";
            this.Donor_Page.Size = new System.Drawing.Size(84, 29);
            this.Donor_Page.TabIndex = 2;
            this.Donor_Page.Text = "Donor";
            this.Donor_Page.Click += new System.EventHandler(this.Donor_Page_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditButton.FillColor = System.Drawing.Color.Red;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(1036, 97);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(99, 36);
            this.EditButton.TabIndex = 78;
            this.EditButton.Text = "Edit";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DelButton.FillColor = System.Drawing.Color.Red;
            this.DelButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelButton.ForeColor = System.Drawing.Color.White;
            this.DelButton.Location = new System.Drawing.Point(1036, 139);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(99, 36);
            this.DelButton.TabIndex = 79;
            this.DelButton.Text = "del";
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // VDBD
            // 
            this.VDBD.BorderColor = System.Drawing.Color.Red;
            this.VDBD.BorderThickness = 2;
            this.VDBD.Checked = true;
            this.VDBD.CustomFormat = "yyyy-MM-dd";
            this.VDBD.FillColor = System.Drawing.Color.Red;
            this.VDBD.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.VDBD.ForeColor = System.Drawing.Color.White;
            this.VDBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.VDBD.Location = new System.Drawing.Point(868, 123);
            this.VDBD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.VDBD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.VDBD.Name = "VDBD";
            this.VDBD.Size = new System.Drawing.Size(134, 29);
            this.VDBD.TabIndex = 80;
            this.VDBD.Value = new System.DateTime(2022, 5, 25, 23, 30, 38, 0);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Firebrick;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(868, 96);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(121, 27);
            this.guna2HtmlLabel4.TabIndex = 81;
            this.guna2HtmlLabel4.Text = "BirthDate";
            // 
            // VDGender
            // 
            this.VDGender.BackColor = System.Drawing.Color.Transparent;
            this.VDGender.BorderColor = System.Drawing.Color.Red;
            this.VDGender.BorderThickness = 2;
            this.VDGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.VDGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VDGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VDGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VDGender.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.VDGender.ForeColor = System.Drawing.Color.Red;
            this.VDGender.ItemHeight = 30;
            this.VDGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.VDGender.Location = new System.Drawing.Point(188, 123);
            this.VDGender.Name = "VDGender";
            this.VDGender.Size = new System.Drawing.Size(151, 36);
            this.VDGender.TabIndex = 82;
            // 
            // DTshow
            // 
            this.DTshow.AllowUserToAddRows = false;
            this.DTshow.AllowUserToDeleteRows = false;
            this.DTshow.AllowUserToResizeColumns = false;
            this.DTshow.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DTshow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DTshow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTshow.BackgroundColor = System.Drawing.Color.White;
            this.DTshow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTshow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTshow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTshow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DTshow.ColumnHeadersHeight = 20;
            this.DTshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTshow.DefaultCellStyle = dataGridViewCellStyle6;
            this.DTshow.EnableHeadersVisualStyles = false;
            this.DTshow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DTshow.Location = new System.Drawing.Point(32, 211);
            this.DTshow.MultiSelect = false;
            this.DTshow.Name = "DTshow";
            this.DTshow.ReadOnly = true;
            this.DTshow.RowHeadersVisible = false;
            this.DTshow.RowHeadersWidth = 51;
            this.DTshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTshow.Size = new System.Drawing.Size(1102, 427);
            this.DTshow.TabIndex = 83;
            this.DTshow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DTshow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DTshow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DTshow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DTshow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DTshow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DTshow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DTshow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTshow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTshow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DTshow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DTshow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTshow.ThemeStyle.HeaderStyle.Height = 20;
            this.DTshow.ThemeStyle.ReadOnly = true;
            this.DTshow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DTshow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTshow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DTshow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DTshow.ThemeStyle.RowsStyle.Height = 22;
            this.DTshow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTshow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DTshow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTshow_CellClick);
            this.DTshow.SelectionChanged += new System.EventHandler(this.DTshow_SelectionChanged);
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
            this.DCityInsert.Location = new System.Drawing.Point(713, 124);
            this.DCityInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DCityInsert.Name = "DCityInsert";
            this.DCityInsert.PasswordChar = '\0';
            this.DCityInsert.PlaceholderText = "";
            this.DCityInsert.SelectedText = "";
            this.DCityInsert.Size = new System.Drawing.Size(148, 28);
            this.DCityInsert.TabIndex = 85;
            // 
            // DCity
            // 
            this.DCity.AutoSize = false;
            this.DCity.BackColor = System.Drawing.Color.Transparent;
            this.DCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCity.ForeColor = System.Drawing.Color.Firebrick;
            this.DCity.Location = new System.Drawing.Point(713, 96);
            this.DCity.Name = "DCity";
            this.DCity.Size = new System.Drawing.Size(68, 27);
            this.DCity.TabIndex = 84;
            this.DCity.Text = "City ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BloodBank.Properties.Resources.icons8_blood_641;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(657, 165);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(39, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 86;
            this.guna2PictureBox1.TabStop = false;
            // 
            // view_donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 640);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.DCityInsert);
            this.Controls.Add(this.DCity);
            this.Controls.Add(this.DTshow);
            this.Controls.Add(this.VDGender);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.VDBD);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VDEmail);
            this.Controls.Add(this.DEmail);
            this.Controls.Add(this.VDBlood);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.VDName);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view_donor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "view_donor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private Guna.UI2.WinForms.Guna2ComboBox VDBlood;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.TextBox textBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox VDName;
        private Guna.UI2.WinForms.Guna2TextBox VDEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel DEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label DashBoard_Page;
        private System.Windows.Forms.Label BloodTransfer_Page;
        private System.Windows.Forms.Label ViewPatients_Page;
        private System.Windows.Forms.Label Patients_page;
        private System.Windows.Forms.Label ViewDonors_Page;
        private System.Windows.Forms.Label Donor_Page;
        private Guna.UI2.WinForms.Guna2Button EditButton;
        private Guna.UI2.WinForms.Guna2Button DelButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker VDBD;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox VDGender;
        private Guna.UI2.WinForms.Guna2DataGridView DTshow;
        private Guna.UI2.WinForms.Guna2TextBox DCityInsert;
        private Guna.UI2.WinForms.Guna2HtmlLabel DCity;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}