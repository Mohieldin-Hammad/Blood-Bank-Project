using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BloodBank.AccessManagers
{
    class User
    {
        public string signUp(string email, string pass, string name, string gender, string BD)
        {
            UserManager user = new UserManager();
            return user.userSignUp(email, pass, name, gender, BD);
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
