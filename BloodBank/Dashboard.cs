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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void donor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void ptlabel_Click(object sender, EventArgs e)
        {
            view_patient P2 = new view_patient();
            P2.Show();
            this.Hide();

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void donor_Click_1(object sender, EventArgs e)
        {
            donor_page D1 = new donor_page();
            D1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            view_donor D2 = new view_donor();
            D2.Show();
            this.Hide();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            Patient_Page P1 = new Patient_Page();
            P1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Transfer T1 = new Transfer();
            T1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
