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
    public class Donor
    {
        public string InsertNewDonor(string name, string gender, string blood, string BD, string phone, string city)
        {
            Manager manager = new Manager();

            string result = manager.Insert("sp_InsertDonor", name, gender, blood, BD, phone, city);
            if (result == "Failed")
            {
                return "MissInformation";
            }
            else if (result == "Succeed")
            {
                return "Done";
            }
            else 
            {
                return result;
            }
        }




        public DataTable ShowDonors()
        {
            Manager manager = new Manager();
            return manager.Select("sp_ShowDonorsTable");
        }


        // will return list of values else it will return null
        public List<string> ValuesOfDonorRow(int id, params string[] cols)
        {
            Manager manager = new Manager();
            List<string> items = manager.getColumnsByID('D', id, cols);
            return items;
        }



        public string EditDonor(int ID, string name, string gender, string blood, string BD, string phone, string city)
        {
            Manager manager = new Manager();
            string result = manager.Edit("sp_EditDRowOfId", ID, name, gender, blood, BD, phone, city);

            if (result == "Failed")
            {
                return "MissInformation";
            }
            else if (result == "Succeed")
            {
                return "Done";
            }
            else
            {
                return result;
            }
        }


        public string RemoveDonor(int ID, string name, string gender, string blood, string age, string phone, string city)
        {
            Manager manager = new Manager();
            List<string> checkAge = ValuesOfDonorRow(ID, "P_Age", "PBirthDate");

            if (checkAge[0] == age)
            {
                string result = manager.Delete("sp_DeleteDonorRow", ID, name, gender, blood, checkAge[1], phone, city);

                if
                    (result == "Succeed") return "Done";
                else
                    return result;
            }

            return "Failed";
        }


        public DataTable SelectAllDonorID()
        {
            Manager manager = new Manager();
            return manager.SelectAllPeopleID("D");
        }


        public string CheckDonorByID(int id)
        {
            Manager manager = new Manager();
            string result = manager.CheckPersonByID(id, "D");
            return result;
        }

        public string CheckDonorByName(string name)
        {
            Manager manager = new Manager();
            string result = manager.CheckPersonByName(name, "D");
            return result;
        }


        public int DonorIDOfName(string name)
        {
            Manager manager = new Manager();
            return manager.selectIDOfName(name, "D");
        }


        public int donorsCount()
        {
            DataTable dt = SelectAllDonorID();
            return dt.Rows.Count;
        }
    }
}
