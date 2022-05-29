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
    public partial class loading_page : Form
    {
        public loading_page()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";
            if (circularProgressBar1.Value == 100)
            {

                timer1.Enabled = false;
                Login log = new Login();
                log.Show();
                this.Hide();

            }           
        }

        private void loading_page_Load(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
