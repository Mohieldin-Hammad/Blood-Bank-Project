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
    public class Manager
    {
        // insert people function
        // will get the procedure name that will be used in the execution, name of the person
        // blood type, person gender(Male, Female), BirthDate as YYYY-MM-DD, phone number as string, city
        public string Insert(string procedure, string name, string gender, string blood, string BD, string phone, string city)
        {
            // starting the connection with sql
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                // if there is any missing information while the insertion it will return Failed  
                if (CheckMissingInformation(name, gender, blood, BD, phone, city)) 
                {
                    return "Failed";
                }
                else // else if there is no el
                {
                    try
                    {
                        // open the connection and 
                        conn.Open();
                        SqlCommand cmd = new SqlCommand($"exec {procedure} '{name}', '{gender}', '{blood}', '{BD}', '{phone}', '{city}'", conn);
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



        public DataTable Select(string procedure)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                string Query = $"exec {procedure}";
                DataSet dataSet = GetDataSet(Query, conn);
                return dataSet.Tables[0];
            }
        }


        public DataTable SelectAllPeopleID(string type)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                try
                {
                    string Query = $"exec sp_SelectAllPeopleId '{type}'";
                    DataSet dataSet = GetDataSet(Query, conn);
                    return dataSet.Tables[0];
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
                return null;
                
            }
        }


        public int selectIDOfName(string name, string type)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                try
                {
                    string Query = $"exec sp_SelectIDOfName '{name}', '{type}'";
                    DataSet dataSet = GetDataSet(Query, conn);
                    return int.Parse(dataSet.Tables[0].Rows[0]["P_ID"].ToString());
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
                return -1;

            }
        }


        public List<string> getColumnsByID(char type, int id, params string[] cols)
        {
            // checking that the id exists



            //*************************

            string[] all_items = new string[7] { "PName", "PBlood", "PGender", "PBirthDate", "PPhone", "PCity", "P_Age"};

            foreach (string item in cols)
            {
                if (!all_items.Contains(item))
                {
                    MessageBox.Show("Columns are not matched");
                    return null;
                }
            }

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                string Query = "";
                if (type == 'P')
                    Query = $"exec sp_SelectPRowOfId {id}";
                else if (type == 'D')
                    Query = $"exec sp_SelectDRowOfId {id}";

                DataSet dataSet = GetDataSet(Query, conn);

                List<string> ListOfValues = new List<string>();
                //ListOfValues[0] = dataSet.Tables[0].Rows[0]["PName"].ToString();

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (string col in cols)
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


        // There is two procedurs 
        // sp_BloodDecrement or sp_BloodIncrement
        private string ChangeBloodCount(string procedure, string blood)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"exec {procedure} '{blood}'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return ex.Message;
                }
            }
            return "Succeed";
        }


        public string CheckPersonByID(int id, string personType)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                string Query = $"exec sp_CheckPersonByID {id}, '{personType}'";
                DataSet dataSet = GetDataSet(Query, conn);
                return dataSet.Tables[0].Rows[0][0].ToString();

            }
        }

        public string CheckPersonByName(string name, string personType)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                string Query = $"exec sp_CheckPersonByName '{name}', '{personType}'";
                DataSet dataSet = GetDataSet(Query, conn);
                return dataSet.Tables[0].Rows[0][0].ToString();
            }
        }


        public string InsertDonation(int id)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                try
                {
                    conn.Open();

                    string bloodType = getColumnsByID('D', id, "PBlood")[0];
                    if (ChangeBloodCount("sp_BloodIncrement", bloodType) != "Succeed")
                    {
                        return "Failed_To_Increment_Blood";
                    }

                    SqlCommand cmd = new SqlCommand($"exec sp_InsertDonation {id}", conn);
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

        public string InsertInjection(int id)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {
                try
                {
                    conn.Open();

                    string bloodType = getColumnsByID('P', id, "PBlood")[0];
                    if (ChangeBloodCount("sp_BloodDecrement", bloodType) != "Succeed")
                    {
                        return "Failed_To_Decrement_Blood";
                    }

                    SqlCommand cmd = new SqlCommand($"exec sp_InsertInjection {id}", conn);
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


        //public string GetBloodcount()
        //{
        //    //string[] bloods = new string[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
            
        //    //// checking that the selected parameters is contained in blood types else it will return null
        //    //foreach (string blood in bloodTypes)
        //    //{
        //    //    if (!bloods.Contains(blood.ToUpper()))
        //    //    {
        //    //        return null;
        //    //    }
        //    //}
            
        //}


        // Execute sql query and return DataSet
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
