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
    public partial class view_patient : Form
    {
        public view_patient()
        {
            InitializeComponent();
            showtable();

        }

        public void showtable()
        {
            AccessManagers.Patient PT = new AccessManagers.Patient();
            PTshow.DataSource = PT.ShowPatients();
            if (PTshow.Rows.Count == 0)
            {
                resetLabels();
            }
        }


        private void resetLabels()
        {
            VPName.Text = "";
            VPGender.SelectedIndex = -1;
            VPPhone.Text = "";
            VPCity.Text = "";
            VPBlood.SelectedIndex = -1;
        }


        // this function is used to get the cell values of the selected row and pass it to the labels 
        private void Select_PTshow_Row()
        {
            AccessManagers.Patient PT = new AccessManagers.Patient();
            int currentRowIndex = PTshow.CurrentCell.RowIndex;
            int id = (int)PTshow.Rows[currentRowIndex].Cells[0].Value;
            List<string> items = PT.ValuesOfPatientRow(id, "PName", "PGender", "PBlood", "PBirthDate", "PPhone", "PCity");
            if (items.Count != 0) { 
            // call setValuesInLabels function which is used to write each cell value into the It's labels text
            SetValuesInLabels(items[0], items[1], items[2], items[3], items[4], items[5]);
            }
        }


        //awel haga value pt take id then comma add name of columns as string 
        private void PTshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Select_PTshow_Row();
            }
        }

        
        // assign each value to the label text
        private void SetValuesInLabels(string name, string gender, string blood, string bd, string phone, string city)
        {
            VPName.Text = name;
            VPGender.Text = gender;
            VPBlood.Text = blood;
            VPBD.Text = bd;
            VPPhone.Text = phone;
            VPCity.Text = city;
        }

        // return the columns that are not the id
        // will return list of items [name, blood, gender, age, phone, city]
        private string[] getRowValues(int index)
        {
            string[] values = new string[7];
            values[0] = PTshow.Rows[index].Cells[1].Value.ToString();
            values[1] = PTshow.Rows[index].Cells[2].Value.ToString();
            values[2] = PTshow.Rows[index].Cells[3].Value.ToString();
            values[3] = PTshow.Rows[index].Cells[4].Value.ToString();
            values[4] = PTshow.Rows[index].Cells[5].Value.ToString();
            values[5] = PTshow.Rows[index].Cells[6].Value.ToString();
            return values;
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

        }

        private void BloodTransfer_Page_Click(object sender, EventArgs e)
        {
            Transfer TPage = new Transfer();
            TPage.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PTshow_SelectionChanged(object sender, EventArgs e)
        {
            if (PTshow.CurrentRow != null) {
                Select_PTshow_Row();
            }
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int currentRowIndex = PTshow.CurrentCell.RowIndex;
            int id = (int)PTshow.Rows[currentRowIndex].Cells[0].Value;

            AccessManagers.Patient patient = new AccessManagers.Patient();
            
            VPBD.Format = DateTimePickerFormat.Custom;
            VPBD.CustomFormat = "yyyy-MM-dd";
            string checkEdit = patient.EditPatient(id, VPName.Text, VPGender.Text, VPBlood.Text, VPBD.Text, VPPhone.Text, VPCity.Text);
            
            if (checkEdit == "MissInformation")
            {
                MessageBox.Show("Missing Information");
            }
            else if (checkEdit == "Done")
            {
                MessageBox.Show("Patient is Successfully Updated");
            }
            else
            {
                MessageBox.Show(checkEdit);
            }
            showtable();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            AccessManagers.Patient patient = new AccessManagers.Patient();
            int currentRowIndex = PTshow.CurrentCell.RowIndex;
            int id = (int)PTshow.Rows[currentRowIndex].Cells[0].Value;
            string[] col = getRowValues(currentRowIndex);
            
            // Because the getRowValues switch between gender and blood, So I will swith it while I type the parameter
            string checkRemove = patient.RemovePatient(id, col[0], col[2], col[1], col[3], col[4], col[5]);
            
            if (checkRemove == "Done") 
                MessageBox.Show("Patient Successfully Deleted");
            else if
                (checkRemove == "Failed") MessageBox.Show("Age are not Matched");
            else
                MessageBox.Show(checkRemove);
            
            showtable();
        }

        private void Donor_Page_Click(object sender, EventArgs e)
        {
            donor_page DPage = new donor_page();
            DPage.Show();
            this.Hide();
        }
    }
}
