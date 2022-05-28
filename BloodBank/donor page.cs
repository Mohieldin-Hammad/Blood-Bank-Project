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
    public partial class donor_page : Form
    {
        public donor_page()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DSaveInsert_Click(object sender, EventArgs e)
        {
            AccessManagers.Donor DonorInsert = new AccessManagers.Donor();

            DBirthDateInsert.Format = DateTimePickerFormat.Custom;
            DBirthDateInsert.CustomFormat = "yyyy-MM-dd";

            string CheckMassage = DonorInsert.InsertNewDonor(DNameInsert.Text, DGenderInsert.Text, DBloodInsert.Text, DBirthDateInsert.Text, DPhoneInsert.Text, DCityInsert.Text);

            if (CheckMassage == "Done" && CheckMassage != null)
            {
                MessageBox.Show("Donor Successfully Seved");
                ResetDonor();
            }
            else if (CheckMassage == "MissInformation")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                MessageBox.Show(CheckMassage);
            }

        }

            private void ResetDonor()
            {
                DNameInsert.Text = "";
                DBloodInsert.SelectedIndex = -1;
                DGenderInsert.SelectedIndex = -1;
                DPhoneInsert.Text = "";
                DCityInsert.Text = "";
            }

        private void DashBoard_Page_Click(object sender, EventArgs e)
        {
            Dashboard DashBoardPage = new Dashboard();
            DashBoardPage.Show();
            this.Hide();
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

        private void BloodTransfer_Page_Click(object sender, EventArgs e)
        {
            Transfer TPage = new Transfer();
            TPage.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    