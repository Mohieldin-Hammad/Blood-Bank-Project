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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            setBloods();
        }



        private void setBloods()
        {
            AccessManagers.Blood blood = new AccessManagers.Blood();// A
            string AP = blood.getCountOfBloods("A+");
            circularProgressBarAP.Value = int.Parse(AP);
            AP_Count.Text = AP;
            string AM = blood.getCountOfBloods("A-");
            circularProgressBarAM.Value = int.Parse(AM);
            AM_Count.Text = AM;

            // B
            string BP = blood.getCountOfBloods("B+");
            circularProgressBarBP.Value = int.Parse(BP);
            BP_Count.Text = BP;
            string BM = blood.getCountOfBloods("B-");
            circularProgressBarBM.Value = int.Parse(BM);
            BM_Count.Text = BM;

            // AB
            string ABP = blood.getCountOfBloods("AB+");
            circularProgressBarABP.Value = int.Parse(ABP);
            ABP_Count.Text = ABP;
            string ABM = blood.getCountOfBloods("AB-");
            circularProgressBarABM.Value = int.Parse(ABM);
            ABM_Count.Text = ABM;

            // O
            string OP = blood.getCountOfBloods("O+");
            circularProgressBarOP.Value = int.Parse(OP);
            OP_Count.Text = OP;
            string OM = blood.getCountOfBloods("O-");
            circularProgressBarOM.Value = int.Parse(BM);
            OM_Count.Text = OM;
            
            //-----------------
            //AP_Count.Text = blood.getCountOfBloods("A+");
            //AM_Count.Text = blood.getCountOfBloods("A-");
            //BP_Count.Text = blood.getCountOfBloods("B+");
            //BM_Count.Text = blood.getCountOfBloods("B-");
            //ABP_Count.Text = blood.getCountOfBloods("AB+");
            //ABM_Count.Text = blood.getCountOfBloods("AB-");
            //OP_Count.Text = blood.getCountOfBloods("O+");
            //OM_Count.Text = blood.getCountOfBloods("O-");
           //-----------------
        }


        private void DashBoard_Page_Click(object sender, EventArgs e)
        {

        }

        private void Donor_Page_Click(object sender, EventArgs e)
        {
            donor_page DPage = new donor_page();
            DPage.Show();
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
            this.Close();
        }

        
    }
}
