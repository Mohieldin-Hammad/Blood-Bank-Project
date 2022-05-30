using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace BloodBank.AccessManagers
{
    public class Blood
    {
        public DataTable ShowBloodsTable()
        {
            Manager manager = new Manager();
            
            return manager.Select("sp_ShowBloodsTable");
        }


        public string Donate(int id)
        {
            string msg;
            Manager manager = new Manager();
            if (manager.CheckPersonByID(id, "D") == "FOUND")
            {
                msg = manager.InsertDonation(id);

                if (msg == "Failed_To_Increment_Blood")
                    return "IncrementFailed";
                else if (msg == "Succeed") 
                {
                    string phone = manager.getColumnsByID('D', id, "PPhone")[0];
                    string name = manager.getColumnsByID('D', id, "PName")[0];
                    string firstName = "";
                    try
                    {
                        firstName = name.Split(' ')[0];
                    }
                    catch (Exception)
                    {
                        firstName = name;
                    }
                    Controllers.SMTPWithMailKit sMTP = new Controllers.SMTPWithMailKit();
                    string smtpCheck = sMTP.SendEmailTo(phone, firstName, "Donation");
                    return "Done";
                }
                else
                    return msg;
            }
            else
                return "There is no donors found with this ID";
        }


        public string Transfer(int id)
        {
            string msg;
            Manager manager = new Manager();
            if (manager.CheckPersonByID(id, "P") == "FOUND")
            {
                msg = manager.InsertInjection(id);

                if (msg == "Failed_To_Decrement_Blood")
                    return "DecrementFailed";
                else if (msg == "Succeed")
                    return "Done";
                else
                    return msg;
            }
            else
                return "There is no patients found with this ID";
        }



        public string getCountOfBloods(string blood)
        {
            string[] bloods = new string[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };

            // checking that the selected parameter is contained in blood types else it will return null
                if (!bloods.Contains(blood.ToUpper()))
                {
                    return null;
                }


            string bloodCount = "";

            DataTable bloodTable = this.ShowBloodsTable();
            foreach (DataRow row in bloodTable.Rows)
            {
                if (blood.ToUpper() == row[0].ToString())
                {
                    bloodCount = row[1].ToString();
                }
            }
            return bloodCount;
        }

    }
}
