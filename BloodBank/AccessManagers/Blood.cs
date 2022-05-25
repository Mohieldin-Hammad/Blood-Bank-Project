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
    
        
        public void Donate(int id)
        {
            string msg;
            Manager manager = new Manager();
            if (manager.CheckPerson(id, "D") == "FOUND")
            {
                msg = manager.InsertDonation(id);

                if (msg == "Failed_To_Increment_Blood")
                    MessageBox.Show("Error: Failed To Increment Blood");
                else if (msg == "Succeed")
                    MessageBox.Show("The donation has successfully happened");
                else
                    MessageBox.Show(msg);
            }
            else
                MessageBox.Show("There is no donors found with this ID");
        }


        public void Transfer(int id)
        {
            string msg;
            Manager manager = new Manager();
            if (manager.CheckPerson(id, "P") == "FOUND")
            {
                msg = manager.InsertInjection(id);

                if (msg == "Failed_To_Decrement_Blood")
                    MessageBox.Show("Error: There Is No Bloods Found From This Type!");
                else if (msg == "Succeed")
                    MessageBox.Show("The transfer has successfully happened");
                else
                    MessageBox.Show(msg);
            }
            else
                MessageBox.Show("There is no patients found with this ID");
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
