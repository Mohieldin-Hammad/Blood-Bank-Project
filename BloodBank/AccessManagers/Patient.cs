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
    public class Patient
    {

        // Inserting new patient to the database will require the following parameters
        // Name of the patient, gender (Male or Female), blood type, BD, phone, city
        // And InsertNewPatient will return messagebox that define the result and if the insertion successfully worked
        public string InsertNewPatient(string name, string gender, string blood,string BD, string phone, string city)
        {
            Manager manager = new Manager();
            
            // All the possible results for Insert method are "Failed" or "Succeed" or "Any other exeption message"
            // Failed happen when there is at least one missing Information
            // Succeed happen if all the information is valid
            // else It will send an exeption.message that show the error message
            string result = manager.Insert("sp_InsertPatient", name, gender, blood, BD, phone, city);

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




        public DataTable ShowPatients()
        {
            Manager manager = new Manager();
            return manager.Select("sp_ShowPatientsTable");
        }


        // will return list of values else it will return null
        public List<string> ValuesOfPatientRow(int id, params string[] cols)
        {
            Manager manager = new Manager();
            List<string> items = manager.getColumnsByID('P', id, cols);
            return items;
        }



        public string EditPatient(int ID, string name, string gender, string blood, string BD, string phone, string city)
        {
            Manager manager = new Manager();
            string result = manager.Edit("sp_EditPRowOfId", ID, name, gender, blood, BD, phone, city);

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

        
        public string RemovePatient(int ID, string name, string gender, string blood, string age, string phone, string city)
        {
            Manager manager = new Manager();
            List<string> checkAge = ValuesOfPatientRow(ID, "P_Age", "PBirthDate");
            
            if (checkAge[0] == age) { 


                // For Debuging
                //-------------------------------
                //MessageBox.Show(ID.ToString());
                //MessageBox.Show(name);
                //MessageBox.Show(gender);
                //MessageBox.Show(blood);
                //MessageBox.Show(phone);
                //MessageBox.Show(city);
                //-------------------------------
                string result = manager.Delete("sp_DeletePatientRow", ID, name, gender, blood, checkAge[1], phone, city);

                if
                    (result == "Succeed") return "Done";
                else
                    return result;
            }
            
            return "Failed";
        }


        public string CheckPatientByID(int id)
        {
            Manager manager = new Manager();
            string result = manager.CheckPersonByID(id, "P");
            return result;
        }

        public string CheckPatientByName(string name)
        {
            Manager manager = new Manager();
            string result = manager.CheckPersonByName(name, "P");
            return result;
        }


        public DataTable SelectAllPatientID()
        {
            Manager manager =new Manager();
            return manager.SelectAllPeopleID("P");
        }

    }
}
