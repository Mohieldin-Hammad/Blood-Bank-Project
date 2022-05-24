namespace BloodBank
{
    partial class login_page
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
            this.namee = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.addname = new System.Windows.Forms.TextBox();
            this.addpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(165, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Bank System";
            // 
            // namee
            // 
            this.namee.AutoSize = true;
            this.namee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namee.ForeColor = System.Drawing.Color.Maroon;
            this.namee.Location = new System.Drawing.Point(112, 182);
            this.namee.Name = "namee";
            this.namee.Size = new System.Drawing.Size(98, 31);
            this.namee.TabIndex = 2;
            this.namee.Text = "Name ";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Maroon;
            this.pass.Location = new System.Drawing.Point(112, 226);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(142, 31);
            this.pass.TabIndex = 3;
            this.pass.Text = "Password";
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // addname
            // 
            this.addname.BackColor = System.Drawing.SystemColors.Menu;
            this.addname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addname.ForeColor = System.Drawing.Color.Maroon;
            this.addname.Location = new System.Drawing.Point(274, 179);
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(343, 38);
            this.addname.TabIndex = 4;
            // 
            // addpass
            // 
            this.addpass.BackColor = System.Drawing.SystemColors.Menu;
            this.addpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpass.ForeColor = System.Drawing.Color.Maroon;
            this.addpass.Location = new System.Drawing.Point(274, 223);
            this.addpass.Name = "addpass";
            this.addpass.Size = new System.Drawing.Size(343, 38);
            this.addpass.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(282, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "continue as admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloodBank.Properties.Resources.icons8_blood_641;
            this.pictureBox1.Location = new System.Drawing.Point(345, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addpass);
            this.Controls.Add(this.addname);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.namee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label namee;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox addname;
        private System.Windows.Forms.TextBox addpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}