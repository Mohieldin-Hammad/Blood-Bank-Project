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
     internal class Manager
    {


        public string Insert(string procedure, string name, string gender, string blood, string BD, string phone, string city)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                if (CheckMissingInformation(name, gender, blood, BD, phone, city))
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



        public DataTable Select(string procedure)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                string Query = $"exec {procedure}";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
        }

        public List<string> getColumnsByID(int id, params string[] cols)
        {
            // checking that the id exists



            //*************************

            string[] all_items = new string[6] {"PName","PBlood", "PGender", "PBirthDate", "PPhone", "PCity"};

            foreach(string item in cols)
            {
                if (!all_items.Contains(item))
                {
                    MessageBox.Show("Columns are not matched");
                    return null;
                }
            }
            
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                string Query = $"exec sp_SelectPRowOfId {id}";
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                
                List<string> ListOfValues = new List<string>();
                //ListOfValues[0] = dataSet.Tables[0].Rows[0]["PName"].ToString();

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach(string col in cols)
                    {
                        ListOfValues.Add(dataSet.Tables[0].Rows[0][col].ToString());
                    }
                }
                return ListOfValues;
            }
        }


        public string Edit(string procedure, int ID, string name, string gender, string blood, string BD, string phone, string city)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                if (CheckMissingInformation(name, gender, blood, BD, phone, city))
                {
                    return "Failed";
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand($"exec {procedure} {ID}, '{name}', '{gender}', '{blood}', '{BD}', '{phone}', '{city}'", conn);
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

        public string Delete(string procedure, int ID, string name, string gender, string blood, string BD, string phone, string city)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                if (CheckMissingAllInformation(name, gender, blood, BD, phone, city))
                {
                    return "FailedAll";
                }
                else if (CheckMissingInformation(name, gender, blood, BD, phone, city))
                {
                    return "Failed";
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand($"exec {procedure} {ID}, '{name}', '{gender}', '{blood}', '{BD}', '{phone}', '{city}'", conn);
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

        // checking if there is a missing information or null string
        private bool CheckMissingInformation(string name, string gender, string blood, string BD, string phone, string city)
        {
            return name == "" || gender == "" || blood == "" || BD == "" || phone == "" || city == "";
        }

        private bool CheckMissingAllInformation(string name, string gender, string blood, string BD, string phone, string city)
        {
            return name == "" && gender == "" && blood == "" && BD == "" && phone == "" && city == "";
        }

    }
}
