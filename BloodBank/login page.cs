using System;
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
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void pass_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            admin_login log2 = new admin_login();
            log2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash1 = new Dashboard();  
            dash1.Show();
            this.Hide();
        }
    }
}
