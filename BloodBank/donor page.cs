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

    }
}
    