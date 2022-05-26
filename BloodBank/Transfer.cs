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

        private void ViewDonors_Page_Click(object sender, EventArgs e)
        {
            view_donor VDPage = new view_donor();
            VDPage.Show();
            this.Hide();
        }

        private void Patients_page_Click(object sender, EventArgs e)
        {
            Patient_Page PPage = new Patient_Page();
            PPage.Show();
            this.Hide();
        }

        private void ViewPatients_Page_Click(object sender, EventArgs e)
        {
            view_patient VPPage = new view_patient();
            VPPage.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Donor_Page_Click(object sender, EventArgs e)
        {
            donor_page DPage = new donor_page();
            DPage.Show();
            this.Hide();
        }
    }
}
