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
    class UserManager
    {
        public bool InsertUser(string name, string pass)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"exec sp_NewUser '{name}', '{pass}'", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return false;
                }
                return true;
                
            }
        }
    }
}
