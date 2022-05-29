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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void DBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void UPSignUP_Click(object sender, EventArgs e)
        {
            AccessManagers.User user = new AccessManagers.User();

            UPBirthDateInsert.Format = DateTimePickerFormat.Custom;
            UPBirthDateInsert.CustomFormat = "yyyy-MM-dd";
            if (CheckSignUpMissingInformation() == false) { 
                if (UPPassInsert.Text == UPConfirmInsert.Text) { 
                    //--------------
                    string email = UPEmailInsert.Text;
                    string pass = UPPassInsert.Text;
                    string name = UPFirstNameInsert.Text.Trim() + " " + UPLastNameInsert.Text.Trim();
                    string gender = UPGenderInsert.Text;
                    string bd = UPBirthDateInsert.Text.Trim();
                    //--------------

                    string checkSignUp = user.SignUp(email, pass, name, gender, bd);
                    if (checkSignUp == "Done")
                    {
                        MessageBox.Show("New account has successfully created");
                        Login lpage = new Login();
                        lpage.Show();
                        this.Hide();
                    }
                    else if (checkSignUp == "MissInformation")
                    { 
                        MessageBox.Show("Some Information are missed");
                        // here I will write method that is changing the colors of  text box
                    }
                    else
                    {
                        MessageBox.Show(checkSignUp);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not matching!");
                }
            }
            else
            {
                MessageBox.Show("Some Information are missed, please make sure that you've completed all the Requirements");
                // here I will write method that is changing the colors of  text box
            }
        }

        private bool CheckSignUpMissingInformation()
        {
            return UPEmailInsert.Text == "" || UPPassInsert.Text == "" || UPFirstNameInsert.Text.Trim() == "" || UPLastNameInsert.Text.Trim() == "" || UPGenderInsert.Text == "" || UPBirthDateInsert.Text.Trim() == "";
        }

        private void eye_Click(object sender, EventArgs e)
        {
            if(UPPassInsert.PasswordChar == '*')
            {
                eye.SendToBack();
                closedeye.BringToFront();
                UPPassInsert.PasswordChar = '\0';
            }
        }

        private void closedeye_Click(object sender, EventArgs e)
        {
            if (UPPassInsert.PasswordChar == '\0')
            {
                closedeye.SendToBack();
                eye.BringToFront();
                UPPassInsert.PasswordChar = '*';
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (UPConfirmInsert.PasswordChar == '*')
            {
                guna2Button1.SendToBack();
                guna2Button2.BringToFront();
                UPConfirmInsert.PasswordChar = '\0';
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (UPConfirmInsert.PasswordChar == '\0')
            {
                guna2Button2.SendToBack();
                guna2Button1.BringToFront();
                UPConfirmInsert.PasswordChar = '*';
            }
        }

        private void UPPassInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Login LPage = new Login();
            LPage.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
