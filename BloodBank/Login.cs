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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        




 

        private void DSaveInsert_Click(object sender, EventArgs e)
        {

            AccessManagers.User user = new AccessManagers.User();
            string email = INEmaiInsert.Text;
            string pass = INPasswordInsert.Text;

            
            string checkLogin = user.Login(email, pass);
            if (checkLogin == "Done")
            {
                ResetLoginPage();
                Dashboard DPage = new Dashboard();
                DPage.Show();
                this.Hide();
                
            }
            else if (checkLogin == "EmailIsNotExists")
            {
                MessageBox.Show("The email address you entered isn't connected to an account");
            }
            else if (checkLogin == "PasswordIsIncorrect")
            {
                MessageBox.Show("The password that you've entered is incorrect");
            }
            else
            {
                MessageBox.Show(checkLogin);
            }

            
        }

        private void ResetLoginPage()
        {
            INEmaiInsert.Text = "";
            INPasswordInsert.Text = "";
        }

        private void INSignUP_Click(object sender, EventArgs e)
        {
            SignUp SPage = new SignUp();
            SPage.Show();
            this.Hide();
        }
    }
}
