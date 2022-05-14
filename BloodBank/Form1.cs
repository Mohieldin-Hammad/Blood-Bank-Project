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
            AccessManagers.Donor donor = new AccessManagers.Donor();
            AccessManagers.Patient patient = new AccessManagers.Patient();
            AccessManagers.Blood blood = new AccessManagers.Blood();


            /*Testing the insertion of patients*/
            //------------------------------------------------
            //dataGridView1.DataSource = patient.ShowPatients();
            //patient.InsertNewPatient("Mohee", "Male", "AB+", "2002-4-20", "847873", "mansoura");
            //patient.InsertNewPatient("mohammed", "Male", "B+", "2002-5-8", "12345", "mansoura");
            //patient.InsertNewPatient("lama", "Female", "O+", "2002-8-8", "255356", "Mansoura");
            //patient.InsertNewPatient("Nadin", "Female", "AB-", "2002-9-9", "578679", "Mansoura");
            //dataGridView1.DataSource = patient.ShowPatients();
            //------------------------------------------------


            /*Testing the insertion of donors*/
            //------------------------------------------------  
            //dataGridView1.DataSource = donor.ShowDonors();
            //donor.InsertNewDonor("Mohee", "Male", "B+", "2002-4-20", "847873", "mansoura");
            //donor.InsertNewDonor("mohammed", "Male", "B+", "2002-5-8", "12345", "mansoura");
            //donor.InsertNewDonor("lama", "Female", "O+", "2002-8-8", "255356", "Mansoura");
            //donor.InsertNewDonor("Nadin", "Female", "AB-", "2002-9-9", "578679", "Mansoura");
            //dataGridView1.DataSource = donor.ShowDonors();
            //------------------------------------------------


            //dataGridView1.DataSource = patient.ShowPatients();
            //dataGridView1.DataSource = donor.ShowDonors();



            /**/
            //------------------------------------------------  
            //dataGridView1.DataSource = blood.ShowBloodsTable();
            //blood.Donate(6);
            //blood.Donate(11);
            //blood.Donate(12);
            //blood.Donate(13);
            //dataGridView1.DataSource = blood.ShowBloodsTable();
            //------------------------------------------------


            /*Testing The selection of specific itmes of patients*/
            //------------------------------------------------  
            //dataGridView1.DataSource = patient.ValuesOfRow(1);
            //List<string> list = patient.ValuesOfPatientRow(2, "PName", "PCity", "PGender", "PBirthDate", "PBlood");
            //if (list != null)
            //{
            //    foreach (string item in list)
            //    {
            //        MessageBox.Show(item);
            //    }
            //}
            //------------------------------------------------


            /*Testing The selection of specific itmes of donors*/
            //------------------------------------------------  
            //List<string> list1 = donor.ValuesOfDonorRow(14, "PName", "PCity", "PGender", "PBirthDate");
            //if (list1 != null)
            //{
            //    foreach (string item in list1)
            //    {
            //        MessageBox.Show(item);
            //    }
            //}
            //------------------------------------------------


            /*Using Edit donor*/
            //------------------------------------------------
            //dataGridView1.DataSource = donor.ShowDonors();
            //donor.EditDonor(11, "Kareem", "Male", "A+", "2002-9-12", "56789", "Tanta");
            //donor.EditDonor(7, "mohamed reda", "Male", "B+", "2002-5-8", "123456", "Mansoura");
            //dataGridView1.DataSource = donor.ShowDonors();
            //------------------------------------------------





            /*using Edit patient*/
            //------------------------------------------------  
            //dataGridView1.DataSource = blood.ShowPatients();
            //patient.EditPatient(2, "Lama Adel", "Female", "O+", "2002-8-8", "255356", "Mansoura");
            //patient.EditPatient(4, "Nadin Abdelrahman", "Female", "AB-", "2002-9-9", "578679", "Mansoura");
            //dataGridView1.DataSource = blood.ShowPatients();
            //------------------------------------------------


            /*transfer blood to patient*/
            //------------------------------------------------  
            //dataGridView1.DataSource = blood.ShowBloodsTable();
            //blood.Transfer(2);
            //blood.Transfer(5);
            //blood.Transfer(8);
            //blood.Transfer(6);
            //dataGridView1.DataSource = blood.ShowBloodsTable();
            //------------------------------------------------


            /**/
            //------------------------------------------------  
            //donor.RemoveDonor(13, "lama", "Female", "O+", "2002-08-08", "255356", "Mansoura");
            //------------------------------------------------


            /**/
            //------------------------------------------------  
            //patient.RemovePatient(5, "mohammed", "Male", "B+", "2002-5-8", "12345", "mansoura");
            //------------------------------------------------


            /*try to make injection with out having blood*/
            //------------------------------------------------  
            //dataGridView1.DataSource = blood.ShowBloodsTable();
            //blood.Transfer(7);
            //dataGridView1.DataSource = blood.ShowBloodsTable();
            //------------------------------------------------



        }
    }
}
