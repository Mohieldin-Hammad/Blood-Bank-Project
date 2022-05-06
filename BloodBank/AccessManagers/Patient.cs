using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBank.AccessManagers
{
    public class Patient
    {
        public void insertPatient(string name, string gender, string blood,string BD, string phone, string city)
        {
            using(SqlConnection conn = new SqlConnection(Helper.CnnVal("BloodBankDB")))
            {

            }
        }

    }
}
