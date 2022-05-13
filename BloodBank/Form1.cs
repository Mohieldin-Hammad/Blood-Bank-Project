using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BloodBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        //private void test()
        //{
        //    using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
        //    {
        //        SqlDataAdapter sda = new SqlDataAdapter("exec sp_ShowDonorsTable", conn);
        //        SqlCommandBuilder builder = new SqlCommandBuilder(sda);

        //        var ds = new DataSet();
        //        sda.Fill(ds);
        //        dataGridView1.DataSource = ds.Tables[0];
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessManagers.Patient patient = new AccessManagers.Patient();

            //patient.InsertNewPatient("Mohee", "Male", "B+", "2002-4-20", "847873", "mansoura");
           //patient.InsertNewPatient("mohammed", "Male", "B+", "2002-5-8", "12345", "mansoura");

            //AccessManagers.Blood blood = new AccessManagers.Blood();


            //dataGridView1.DataSource = blood.ShowPatients();


            //dataGridView1.DataSource = patient.ShowPatients();


            //dataGridView1.DataSource = patient.ValuesOfRow(1);

            //List<string> list = patient.ValuesOfRow(2, "PName", "PCity", "PGender", "PBirthDate");
            //if (list != null)
            //{
            //    foreach (string item in list)
            //    {
            //        MessageBox.Show(item);
            //    }
            //}


            //patient.EditPatient(2, "Mohee", "Male", "B+", "2002-4-20", "56789", "Mansoura");
            //patient.EditPatient(4, "mohamed reda", "Male", "B+", "2002-5-8", "123456", "Mansoura");
            //dataGridView1.DataSource = patient.ShowPatients();

            //patient.RemovePatient(4, "mohamed reda", "Male", "B+", "2002-5-8", "123456", "Mansoura");


            //------------------------------------------------------------------


            AccessManagers.Donor donor = new AccessManagers.Donor();

            donor.InsertNewDonor("Mohee", "Male", "B+", "2002-4-20", "847873", "mansoura");
            donor.InsertNewDonor("mohammed", "Male", "B+", "2002-5-8", "12345", "mansoura");

            List<string> list = donor.ValuesOfRow(7, "PName", "PCity", "PGender", "PBirthDate");
            if (list != null)
            {
                foreach (string item in list)
                {
                    MessageBox.Show(item);
                }
            }


            donor.EditDonor(6, "Mohee", "Male", "B+", "2002-4-20", "56789", "Mansoura");
            donor.EditDonor(7, "mohamed reda", "Male", "B+", "2002-5-8", "123456", "Mansoura");
            dataGridView1.DataSource = donor.ShowDonors();

            donor.RemoveDonor(7, "mohamed reda", "Male", "B+", "2002-5-8", "123456", "Mansoura");

            dataGridView1.DataSource = donor.ShowDonors();
        }
    }
}
