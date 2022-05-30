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
    public partial class view_donor : Form
    {
        public view_donor()
        {
            InitializeComponent();
            showtable();
        }


        public void showtable()
        {
            AccessManagers.Donor DT = new AccessManagers.Donor();
            DTshow.DataSource = DT.ShowDonors();
            if (DTshow.Rows.Count == 0)
            {
                resetLabels();
            }
        }


        private void resetLabels()
        {
            VDName.Text = "";
            VDGender.SelectedIndex = -1;
            VDPhone.Text = "";
            VDCity.Text = "";
            VDBlood.SelectedIndex = -1;
        }

        // this function is used to get the cell values of the selected row and pass it to the labels 
        private void Select_DTshow_Row()
        {
            AccessManagers.Donor DT = new AccessManagers.Donor();
            int currentRowIndex = DTshow.CurrentCell.RowIndex;
            int id = (int)DTshow.Rows[currentRowIndex].Cells[0].Value;
            List<string> items = DT.ValuesOfDonorRow(id, "PName", "PGender", "PBlood", "PBirthDate", "PPhone", "PCity");
            if (items.Count != 0)
            {
                // call setValuesInLabels function which is used to write each cell value into the It's labels text
                SetValuesInLabels(items[0], items[1], items[2], items[3], items[4], items[5]);
            }
        }


        private void SetValuesInLabels(string name, string gender, string blood, string bd, string phone, string city)
        {
            VDName.Text = name;
            VDGender.Text = gender;
            //VDGender.SelectedIndex = VDGender.FindStringExact(gender);
            VDBlood.Text = blood;
            VDBD.Text = bd;
            VDPhone.Text = phone;
            VDCity.Text = city;
        }


        // return the columns that are not the id
        // will return list of items [name, blood, gender, age, phone, city]
        private string[] getRowValues(int index)
        {
            string[] values = new string[7];
            values[0] = DTshow.Rows[index].Cells[1].Value.ToString();
            values[1] = DTshow.Rows[index].Cells[2].Value.ToString();
            values[2] = DTshow.Rows[index].Cells[3].Value.ToString();
            values[3] = DTshow.Rows[index].Cells[4].Value.ToString();
            values[4] = DTshow.Rows[index].Cells[5].Value.ToString();
            values[5] = DTshow.Rows[index].Cells[6].Value.ToString();
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
            donor_page DPage = new donor_page();
            DPage.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DTshow.SelectedRows.Count > 0) 
            { 
                int currentRowIndex = DTshow.CurrentCell.RowIndex;
                int id = (int)DTshow.Rows[currentRowIndex].Cells[0].Value;
                
                if (VDName.Text.Trim() == "" || VDPhone.Text.Trim() == "" || VDCity.Text.Trim() == "")
                {
                    MessageBox.Show("Inputs Cannot be empty");
                }
                else
                {
                    AccessManagers.Donor donor = new AccessManagers.Donor();

                    VDBD.Format = DateTimePickerFormat.Custom;
                    VDBD.CustomFormat = "yyyy-MM-dd";
                
                    string checkEdit = donor.EditDonor(id, VDName.Text, VDGender.Text, VDBlood.Text, VDBD.Text, VDPhone.Text, VDCity.Text);

                    if (checkEdit == "MissInformation")
                    {
                        MessageBox.Show("Missing Information");
                    }
                    else if (checkEdit == "Done")
                    {
                        MessageBox.Show("Donor is Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show(checkEdit);
                    }
                    showtable();
                }
            }
            else
            {
                MessageBox.Show("Row is not selected!");
            }

        }

        private void DTshow_SelectionChanged(object sender, EventArgs e)
        {
            if (DTshow.CurrentRow != null)
            {
                Select_DTshow_Row();
            }
        }

        private void DTshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Select_DTshow_Row();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (DTshow.SelectedRows.Count > 0)
            {
                AccessManagers.Donor donor = new AccessManagers.Donor();
                int currentRowIndex = DTshow.CurrentCell.RowIndex;
                int id = (int)DTshow.Rows[currentRowIndex].Cells[0].Value;
                string[] col = getRowValues(currentRowIndex);

                // Because the getRowValues switch between gender and blood, So I will swith it while I type the parameter
                string checkRemove = donor.RemoveDonor(id, col[0], col[2], col[1], col[3], col[4], col[5]);

                if (checkRemove == "Done")
                    MessageBox.Show("Donor Successfully Deleted");
                else if
                    (checkRemove == "Failed") MessageBox.Show("Age are not Matched");
                else
                    MessageBox.Show(checkRemove);
                showtable();
            }
            else
            {
                MessageBox.Show("Row is not selected!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
