using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBank.AccessManagers
{
     class Manager
    {
        public string Insert(string procedure, string name, string gender, string blood, string BD, string phone, string city)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                if (name == "" || gender == "" || blood == "" || BD == "" || phone == "" || city == "")
                {
                    return "Failed";
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand($"exec {procedure} '{name}', '{gender}', '{blood}', '{BD}', '{phone}', '{city}'", conn);
                        cmd.ExecuteNonQuery();
                        
                        conn.Close();
                        return "Succeed";
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return ex.Message;
                    }
                }
            }
        }
    }
}
