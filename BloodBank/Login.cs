﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash1 = new Dashboard();  
            dash1.Show();
            this.Hide();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SignUp SPage = new SignUp();
            SPage.Show();
            this.Hide();
        }

        private void DSaveInsert_Click(object sender, EventArgs e)
        {
            Dashboard DPage = new Dashboard();
            DPage.Show();
            this.Hide();
        }


    }
}
