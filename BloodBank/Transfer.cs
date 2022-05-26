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
            resetID();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        //binding ID clumns values with combobox
        private void resetID()
        {   
            AccessManagers.Patient patient = new AccessManagers.Patient();
            DataTable patientsID = patient.SelectAllPatientID();
            cmbPatientID.DisplayMember = "P_ID";
            cmbPatientID.DataSource = patientsID;
            cmbPatientID.SelectedItem = null;

            AccessManagers.Donor donor = new AccessManagers.Donor();
            DataTable donorsID = donor.SelectAllDonorID();
            cmbDonorID.DisplayMember = "P_ID";
            cmbDonorID.DataSource = donorsID;
            cmbDonorID.SelectedItem = null;
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

        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatientID.SelectedItem == null)
            {
                PName.Text = "";
                PBlood.Text = "";
            }
            else
            {
                int id = int.Parse(cmbPatientID.Text.ToString());
                AccessManagers.Patient patient = new AccessManagers.Patient();
                if (patient.CheckPatientByID(id) == "FOUND")
                {
                    PName.Text = patient.ValuesOfPatientRow(id, "PName")[0];
                    PBlood.Text = patient.ValuesOfPatientRow(id, "PBlood")[0];
                }
            }
        }

        private void cmbDonorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDonorID.SelectedItem == null)
            {
                DName.Text = "";
                DBlood.Text = "";
            }
            else
            {
                int id = int.Parse(cmbDonorID.Text.ToString());
                AccessManagers.Donor donor = new AccessManagers.Donor();
                if (donor.CheckDonorByID(id) == "FOUND")
                {
                    DName.Text = donor.ValuesOfDonorRow(id, "PName")[0];
                    DBlood.Text = donor.ValuesOfDonorRow(id, "PBlood")[0];
                }
            }
        }

        private void PName_TextChanged(object sender, EventArgs e)
        {
            AccessManagers.Patient patient = new AccessManagers.Patient();
            string name = PName.Text.ToString();
            if (patient.CheckPatientByName(name) == "FOUND")
            {
                int id = patient.patientIDOfName(name);
                cmbPatientID.Text = id.ToString();
                PBlood.Text = patient.ValuesOfPatientRow(id, "PBlood")[0];
            }
            else
            {

                cmbPatientID.SelectedIndex = -1;
                PBlood.Text = "";
            }
        }
    }
}
