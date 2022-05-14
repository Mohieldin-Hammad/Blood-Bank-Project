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
        public void NewUser(string name, string pass)
        {
            UserManager manager = new UserManager();
            if (manager.InsertUser(name, pass))
                MessageBox.Show("User has been add succesfully");
            else
                MessageBox.Show("The process is failed Please try again");
        }

    }
}
