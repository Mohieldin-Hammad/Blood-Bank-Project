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
            AccessManagers.Patient PatientInsert = new AccessManagers.Patient(); PBirthDateInsert.Format = DateTimePickerFormat.Custom;
            PBirthDateInsert.CustomFormat = "yyyy-MM-dd";

            string CheckMassage = PatientInsert.InsertNewPatient(PNameInsert.Text, PGenderInsert.Text, PBloodInsert.Text, PBirthDateInsert.Text, PPhoneInsert.Text, PCityInsert.Text);
            if (CheckMassage == "Done" && CheckMassage != null)
            {
                ResetPatient();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
