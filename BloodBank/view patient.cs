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

        private void view_patient_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void PTshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showtable()
        {
            AccessManagers.Patient PT = new AccessManagers.Patient();
            PTshow.DataSource = PT.ShowPatients();
        }
        //awel haga value pt take id then comma add name of columns as string 
        private void PTshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AccessManagers.Patient PT = new AccessManagers.Patient();
            int ID =  (int)PTshow.Rows[e.RowIndex].Cells[0].Value;
            List<string> items = PT.ValuesOfPatientRow(ID, "PName", "PGender", "PBlood", "PBirthDate", "PPhone");
            

        }
    }
}
