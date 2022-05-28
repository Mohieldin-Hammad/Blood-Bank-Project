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
        public string userSignUp(string email, string pass, string name, string gender, string BD)
        {

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                if (CheckMissingInformation(email, pass, name, gender, BD))
                {
                    return "Failed";
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand($"exec sp_AddUser '{name}', '{email}', '{pass}', '{gender}', '{BD}'", conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return ex.Message;
                    }
                    return "Succeed";
                }
            }
        }


        public string checkEmail(string email) {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                string Query = $"exec sp_checkEmail '{email}'";
                DataSet dataSet = GetDataSet(Query, conn);
                // will return either Succeed or Failed
                return dataSet.Tables[0].Rows[0][0].ToString();
            } 
        }


        public string checkPassword(string email, string password) 
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                string Query = $"exec sp_checkPassword '{email}', '{password}'";
                DataSet dataSet = GetDataSet(Query, conn);
                // will return either Succeed or Failed or EmailNotExists
                return dataSet.Tables[0].Rows[0][0].ToString();
            }
        }


        private DataSet GetDataSet(string query, SqlConnection conn)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }


        private bool CheckMissingInformation(string email, string pass, string userName, string gender, string BD)
        {
            return email == "" || pass == "" || userName == "" || gender == "" || BD == "";
        }
    }
}
