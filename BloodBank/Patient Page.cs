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
    public partial class Patient_Page : Form
    {
        public Patient_Page()
        {
            InitializeComponent();
        }

        

        private void ptblood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PNameInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void Patient_Page_Load(object sender, EventArgs e)
        {

        }

        private void PSaveInsert_Click(object sender, EventArgs e)
        {
            AccessManagers.Patient PatientInsert = new AccessManagers.Patient(); 
            
            PBirthDateInsert.Format = DateTimePickerFormat.Custom;
            PBirthDateInsert.CustomFormat = "yyyy-MM-dd";

            string CheckMassage = PatientInsert.InsertNewPatient(PNameInsert.Text, PGenderInsert.Text, PBloodInsert.Text, PBirthDateInsert.Text, PPhoneInsert.Text, PCityInsert.Text);
            
            if (CheckMassage == "Done" && CheckMassage != null)
            {
                MessageBox.Show("Patient Successfully Seved");
                ResetPatient();
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

        private void ResetPatient()
        {
            PNameInsert.Text = "";
            PBloodInsert.SelectedIndex = -1;
            PGenderInsert.SelectedIndex = -1;
            //PBirhDateInsert.Text = "";
            PPhoneInsert.Text = "";
            PCityInsert.Text = "";
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

        private void Donor_Page_Click(object sender, EventArgs e)
        {

        }

        private void PPhone_text_Click(object sender, EventArgs e)
        {

        }

        private void PName_text_Click(object sender, EventArgs e)
        {

        }

        private void PGender_text_Click(object sender, EventArgs e)
        {

        }

        private void PBlood_text_Click(object sender, EventArgs e)
        {

        }

        private void PCity_text_Click(object sender, EventArgs e)
        {

        }

        private void PBD_text_Click(object sender, EventArgs e)
        {

        }
    }
}
