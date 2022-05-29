namespace BloodBank
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.INSignIN = new Guna.UI2.WinForms.Guna2Button();
            this.INSignUP = new Guna.UI2.WinForms.Guna2Button();
            this.ViewDonors_Page = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.INEmaiInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.INPasswordInsert = new Guna.UI2.WinForms.Guna2TextBox();
            this.eye = new Guna.UI2.WinForms.Guna2Button();
            this.closedeye = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 62;
            this.label1.Text = "Blood Bank System";
            // 
            // INSignIN
            // 
            this.INSignIN.BorderRadius = 10;
            this.INSignIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.INSignIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.INSignIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.INSignIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.INSignIN.FillColor = System.Drawing.Color.Red;
            this.INSignIN.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSignIN.ForeColor = System.Drawing.Color.White;
            this.INSignIN.Location = new System.Drawing.Point(92, 375);
            this.INSignIN.Name = "INSignIN";
            this.INSignIN.Size = new System.Drawing.Size(135, 44);
            this.INSignIN.TabIndex = 68;
            this.INSignIN.Text = "Sign In";
            this.INSignIN.Click += new System.EventHandler(this.DSaveInsert_Click);
            // 
            // INSignUP
            // 
            this.INSignUP.BorderRadius = 10;
            this.INSignUP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.INSignUP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.INSignUP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.INSignUP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.INSignUP.FillColor = System.Drawing.Color.Red;
            this.INSignUP.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSignUP.ForeColor = System.Drawing.Color.White;
            this.INSignUP.Location = new System.Drawing.Point(232, 375);
            this.INSignUP.Name = "INSignUP";
            this.INSignUP.Size = new System.Drawing.Size(135, 44);
            this.INSignUP.TabIndex = 70;
            this.INSignUP.Text = "Sign Up";
            this.INSignUP.Click += new System.EventHandler(this.INSignUP_Click);
            // 
            // ViewDonors_Page
            // 
            this.ViewDonors_Page.AutoSize = true;
            this.ViewDonors_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDonors_Page.ForeColor = System.Drawing.Color.Firebrick;
            this.ViewDonors_Page.Location = new System.Drawing.Point(38, 167);
            this.ViewDonors_Page.Name = "ViewDonors_Page";
            this.ViewDonors_Page.Size = new System.Drawing.Size(81, 26);
            this.ViewDonors_Page.TabIndex = 73;
            this.ViewDonors_Page.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(38, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 74;
            this.label2.Text = "Password";
            // 
            // INEmaiInsert
            // 
            this.INEmaiInsert.BorderColor = System.Drawing.Color.Red;
            this.INEmaiInsert.BorderThickness = 2;
            this.INEmaiInsert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.INEmaiInsert.DefaultText = "";
            this.INEmaiInsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.INEmaiInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.INEmaiInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.INEmaiInsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.INEmaiInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.INEmaiInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INEmaiInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.INEmaiInsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.INEmaiInsert.Location = new System.Drawing.Point(43, 197);
            this.INEmaiInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.INEmaiInsert.Name = "INEmaiInsert";
            this.INEmaiInsert.PasswordChar = '\0';
            this.INEmaiInsert.PlaceholderText = "";
            this.INEmaiInsert.SelectedText = "";
            this.INEmaiInsert.Size = new System.Drawing.Size(370, 34);
            this.INEmaiInsert.TabIndex = 65;
            // 
            // INPasswordInsert
            // 
            this.INPasswordInsert.BorderColor = System.Drawing.Color.Red;
            this.INPasswordInsert.BorderThickness = 2;
            this.INPasswordInsert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.INPasswordInsert.DefaultText = "";
            this.INPasswordInsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.INPasswordInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.INPasswordInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.INPasswordInsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.INPasswordInsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.INPasswordInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INPasswordInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.INPasswordInsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.INPasswordInsert.Location = new System.Drawing.Point(43, 281);
            this.INPasswordInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.INPasswordInsert.Name = "INPasswordInsert";
            this.INPasswordInsert.PasswordChar = '*';
            this.INPasswordInsert.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.INPasswordInsert.PlaceholderText = "";
            this.INPasswordInsert.SelectedText = "";
            this.INPasswordInsert.Size = new System.Drawing.Size(370, 34);
            this.INPasswordInsert.TabIndex = 67;
            this.INPasswordInsert.TextChanged += new System.EventHandler(this.INPasswordInsert_TextChanged);
            // 
            // eye
            // 
            this.eye.BorderColor = System.Drawing.Color.Transparent;
            this.eye.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.eye.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.eye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.eye.FillColor = System.Drawing.Color.White;
            this.eye.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.eye.ForeColor = System.Drawing.Color.White;
            this.eye.Image = global::BloodBank.Properties.Resources.icons8_eye_50;
            this.eye.Location = new System.Drawing.Point(373, 287);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(32, 24);
            this.eye.TabIndex = 83;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // closedeye
            // 
            this.closedeye.BorderColor = System.Drawing.Color.Transparent;
            this.closedeye.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closedeye.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closedeye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closedeye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closedeye.FillColor = System.Drawing.Color.White;
            this.closedeye.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.closedeye.ForeColor = System.Drawing.Color.White;
            this.closedeye.Image = global::BloodBank.Properties.Resources.icons8_eye_502;
            this.closedeye.Location = new System.Drawing.Point(375, 287);
            this.closedeye.Name = "closedeye";
            this.closedeye.Size = new System.Drawing.Size(32, 24);
            this.closedeye.TabIndex = 84;
            this.closedeye.Click += new System.EventHandler(this.closedeye_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BloodBank.Properties.Resources.icons8_user_90;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(174, 80);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(90, 90);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 63;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Location = new System.Drawing.Point(407, 14);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(31, 29);
            this.Exit.TabIndex = 87;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 485);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.eye);
            this.Controls.Add(this.closedeye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewDonors_Page);
            this.Controls.Add(this.INSignUP);
            this.Controls.Add(this.INSignIN);
            this.Controls.Add(this.INPasswordInsert);
            this.Controls.Add(this.INEmaiInsert);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_page";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button INSignIN;
        private Guna.UI2.WinForms.Guna2Button INSignUP;
        private System.Windows.Forms.Label ViewDonors_Page;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox INEmaiInsert;
        private Guna.UI2.WinForms.Guna2TextBox INPasswordInsert;
        private Guna.UI2.WinForms.Guna2Button eye;
        private Guna.UI2.WinForms.Guna2Button closedeye;
        private System.Windows.Forms.Label Exit;
    }
}