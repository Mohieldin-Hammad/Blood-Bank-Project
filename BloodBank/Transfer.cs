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
            cmbDonorID.DisplayMember = "P_ID";
            cmbDonorID.DataSource = patientsID;
            cmbDonorID.SelectedItem = null;
            DName.Text = "";
            DBlood.Text = "";

            

            AccessManagers.Donor donor = new AccessManagers.Donor();
            DataTable donorsID = donor.SelectAllDonorID();
            cmbPatientID.DisplayMember = "P_ID";
            cmbPatientID.DataSource = donorsID;
            cmbPatientID.SelectedItem = null;
            PName.Text = "";
            PBlood.Text = "";
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


        // this two boolean variable will control the logic if clicking and typing in labels and comboboxes
        private bool AllowPatientHandeler = true;
        private bool AllowDonorHandeler = true;

        private void cmbDonorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllowDonorHandeler)
            {
                if (cmbPatientID.SelectedIndex != -1)
                {
                    int id = int.Parse(cmbPatientID.Text.ToString());
                    AccessManagers.Donor donor = new AccessManagers.Donor();
                    if (donor.CheckDonorByID(id) == "FOUND")
                    {
                        PName.Text = donor.ValuesOfDonorRow(id, "PName")[0];
                        PBlood.Text = donor.ValuesOfDonorRow(id, "PBlood")[0];
                    }
                }
            }
        }

        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllowPatientHandeler)
            {
                if (cmbDonorID.SelectedIndex != -1)
                {
                    int id = int.Parse(cmbDonorID.Text.ToString());
                    AccessManagers.Patient patient = new AccessManagers.Patient();
                    if (patient.CheckPatientByID(id) == "FOUND")
                    {
                        DName.Text = patient.ValuesOfPatientRow(id, "PName")[0];
                        DBlood.Text = patient.ValuesOfPatientRow(id, "PBlood")[0];
                    }
                }
            }
        }



        private void DName_TextChanged(object sender, EventArgs e)
        {
            AccessManagers.Donor donor = new AccessManagers.Donor();
            string name = PName.Text.ToString();

            if (donor.CheckDonorByName(name) == "FOUND")
            {
                AllowDonorHandeler = true;
                int id = donor.DonorIDOfName(name);

                cmbPatientID.SelectedIndex = cmbPatientID.FindStringExact(id.ToString());
                PBlood.Text = donor.ValuesOfDonorRow(id, "PBlood")[0];
            }
            else
            {
                AllowDonorHandeler = false;
                cmbPatientID.SelectedIndex = -1;
                cmbPatientID.SelectedIndex = -1;
                PBlood.Text = "";
            }
        }

        private void PName_TextChanged(object sender, EventArgs e)
        {
            AccessManagers.Patient patient = new AccessManagers.Patient();
            string name = DName.Text.ToString();

            if (patient.CheckPatientByName(name) == "FOUND")
            {
                AllowPatientHandeler = true;
                int id = patient.patientIDOfName(name);

                cmbDonorID.SelectedIndex = cmbDonorID.FindStringExact(id.ToString());
                DBlood.Text = patient.ValuesOfPatientRow(id, "PBlood")[0];
            }
            else
            {
                AllowPatientHandeler = false;
                cmbDonorID.SelectedIndex = -1;
                cmbDonorID.SelectedIndex = -1;
                DBlood.Text = "";
            }
        }


        private void cmbDonorID_Click(object sender, EventArgs e)
        {
            AllowDonorHandeler = true;
        }

        private void cmbPatientID_Click(object sender, EventArgs e)
        {
            AllowPatientHandeler = true;
        }



        private void donateButton_Click(object sender, EventArgs e)
        {
            //if (cmpDonor)
            //AccessManagers.Donor donor = new AccessManagers.Donor();
            //int id = int.Parse(cmbPatientID.Text.ToString());
            //string name = donor.ValuesOfDonorRow(id, )
        }

        
    }
}
