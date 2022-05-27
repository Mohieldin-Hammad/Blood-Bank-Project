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
            PName.Text = "";
            PBlood.Text = "";

            

            AccessManagers.Donor donor = new AccessManagers.Donor();
            DataTable donorsID = donor.SelectAllDonorID();
            cmbDonorID.DisplayMember = "P_ID";
            cmbDonorID.DataSource = donorsID;
            cmbDonorID.SelectedItem = null;
            DName.Text = "";
            DBlood.Text = "";
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
        private void DashBoard_Page_Click(object sender, EventArgs e)
        {
            Dashboard DashBoardPage = new Dashboard();
            DashBoardPage.Show();
            this.Hide();
        }


        // this two boolean variable will control the logic if clicking and typing in labels and comboboxes
        private bool AllowPatientHandeler = false;
        private bool AllowDonorHandeler = false;

        private void cmbDonorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllowDonorHandeler)
            {
                if (cmbDonorID.SelectedIndex != -1)
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
        }

        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllowPatientHandeler)
            {
                if (cmbPatientID.SelectedIndex != -1)
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
        }



        private void DName_TextChanged(object sender, EventArgs e)
        {
            AccessManagers.Donor donor = new AccessManagers.Donor();
            string name = DName.Text.ToString();

            if (donor.CheckDonorByName(name) == "FOUND")
            {
                AllowDonorHandeler = true;
                int id = donor.DonorIDOfName(name);

                cmbDonorID.SelectedIndex = cmbDonorID.FindStringExact(id.ToString());
                DBlood.Text = donor.ValuesOfDonorRow(id, "PBlood")[0];
            }
            else
            {
                AllowDonorHandeler = false;
                cmbDonorID.SelectedIndex = -1;
                cmbDonorID.SelectedIndex = -1;
                DBlood.Text = "";
            }
        }

        private void PName_TextChanged(object sender, EventArgs e)
        {
            AccessManagers.Patient patient = new AccessManagers.Patient();
            string name = PName.Text.ToString();

            if (patient.CheckPatientByName(name) == "FOUND")
            {
                AllowPatientHandeler = true;
                int id = patient.patientIDOfName(name);

                cmbPatientID.SelectedIndex = cmbPatientID.FindStringExact(id.ToString());
                PBlood.Text = patient.ValuesOfPatientRow(id, "PBlood")[0];
            }
            else
            {
                AllowPatientHandeler = false;
                cmbPatientID.SelectedIndex = -1;
                cmbPatientID.SelectedIndex = -1;
                PBlood.Text = "";
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
            if (cmbDonorID.Text == "" || DName.Text == "" || DBlood.Text == "")
            {
                MessageBox.Show("There are some values missed. Please make sure that you have selected the right person");
            }
            else
            {
                AccessManagers.Donor donor = new AccessManagers.Donor();
                int id = int.Parse(cmbDonorID.Text.ToString());
                string name = donor.ValuesOfDonorRow(id, "PName")[0];
                string blood = donor.ValuesOfDonorRow(id, "PBlood")[0];
                if (name == DName.Text && blood == DBlood.Text)
                {
                    AccessManagers.Blood donorBlood = new AccessManagers.Blood();
                    string checkDonation = donorBlood.Donate(id);
                    if (checkDonation == "IncrementFailed")
                        MessageBox.Show("Error: Failed To Increment Blood");
                    else if (checkDonation == "Done")
                        MessageBox.Show("The donation has successfully happened");
                    else
                        MessageBox.Show(checkDonation);
                }
                else
                {
                    MessageBox.Show("The ID are not matching with the Person Name");
                }

            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (cmbPatientID.Text == "" || PName.Text == "" || PBlood.Text == "")
            {
                MessageBox.Show("There are some values missed. Please make sure that you have selected the right person");
            }
            else
            {
                AccessManagers.Patient patient = new AccessManagers.Patient();
                int id = int.Parse(cmbPatientID.Text.ToString());
                string name = patient.ValuesOfPatientRow(id, "PName")[0];
                string blood = patient.ValuesOfPatientRow(id, "PBlood")[0];
                if (name == PName.Text && blood == PBlood.Text)
                {
                    AccessManagers.Blood patientBlood = new AccessManagers.Blood();
                    string checkTransfer = patientBlood.Transfer(id);
                    if (checkTransfer == "DecrementFailed")
                        MessageBox.Show("Error: There Is No Bloods Found From This Type!");
                    else if (checkTransfer == "Done")
                        MessageBox.Show("The transfer has successfully happened");
                    else
                        MessageBox.Show(checkTransfer);
                }
                else
                {
                    MessageBox.Show("The ID are not matching with the Person Name");
                }

            }
        }
    }
}
