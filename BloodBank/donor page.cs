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
                ResetDonor();
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

        private void donor_page_Load(object sender, EventArgs e)
        {

        }

        private void PBirthDateInsert_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DBloodInsert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGender_Click(object sender, EventArgs e)
        {

        }

        private void DBlood_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGenderInsert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
    