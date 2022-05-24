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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private void Donor(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Arial", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Donor", myfont, mybrush, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            view_donor D2 = new view_donor();
            D2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Transfer T1 = new Transfer();
            T1.Show();
            this.Hide();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            Patient_Page P1 = new Patient_Page();
            P1.Show();
            this.Hide();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
