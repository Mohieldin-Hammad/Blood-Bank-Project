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
                MessageBox.Show("Missing Information");
                return "MissInformation";
            }
            else if (result == "Succeed")
            {
                MessageBox.Show("Patient Successfully Seved");
                return "Done";
            }
            else
                MessageBox.Show(result);

            return null;
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



        public void EditDonor(int ID, string name, string gender, string blood, string BD, string phone, string city)
        {
            Manager manager = new Manager();
            string result = manager.Edit("sp_EditDRowOfId", ID, name, gender, blood, BD, phone, city);

            if (result == "Failed") MessageBox.Show("Missing Information");
            else if (result == "Succeed") MessageBox.Show("Donor is Successfully Updated");
            else MessageBox.Show(result);
        }


        public void RemoveDonor(int ID, string name, string gender, string blood, string BD, string phone, string city)
        {
            Manager manager = new Manager();
            string result = manager.Delete("sp_DeleteDonorRow", ID, name, gender, blood, BD, phone, city);

            if (result == "FailedAll") MessageBox.Show("Select the Donor to Delete");
            else if (result == "Failed") MessageBox.Show("Missing Information");
            else if (result == "Succeed") MessageBox.Show("Donor Successfully Deleted");
            else MessageBox.Show(result);
        }

    }
}
