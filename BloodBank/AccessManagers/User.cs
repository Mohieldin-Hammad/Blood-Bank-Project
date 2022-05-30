using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace BloodBank.AccessManagers
{
    class User
    {
        public string SignUp(string email, string pass, string name, string gender, string BD)
        {
            UserManager user = new UserManager();
            string checkSignUp = user.userSignUp(email, pass, name, gender, BD);
            if (checkSignUp != null && checkSignUp == "Succeed")
                return "Done";
            else if (checkSignUp != null && checkSignUp == "Failed")
                return "MissInformation";
            else
                return checkSignUp;
        }

        private static void sendEmail(string email, string reciever, string cond)
        {
            Controllers.SMTPWithMailKit sMTP = new Controllers.SMTPWithMailKit();
            string smtpCheck = sMTP.SendEmailTo(email, reciever, cond);
        }


        public string Login(string email, string pass)
        {
            UserManager user = new UserManager();
            string checkEmail = user.checkEmail(email);
            if (checkEmail == "Succeed")
            {
                string checkPass = user.checkPassword(email, pass);
                if (checkPass == "Succeed")
                {
                    Thread msg = new Thread(() => sendEmail(email,email, "SignIn"));
                    msg.Start();
                    return "Done";
                }
                else if (checkPass == "Failed")
                {
                    return "PasswordIsIncorrect";
                }
                else
                {
                    return checkPass;
                }
            }
            else if (checkEmail == "Failed")
            {
                return "EmailIsNotExists";
            }
            else
            {
                return checkEmail;
            }
        }
    }
}
