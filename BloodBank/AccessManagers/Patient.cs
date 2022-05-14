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
        public void InsertNewPatient(string name, string gender, string blood,string BD, string phone, string city)
        {
            Manager manager = new Manager();
            
            // All the possible results for Insert method are "Failed" or "Succeed" or "Any other exeption message"
            // Failed happen when there is at least one missing Information
            // Succeed happen if all the information is valid
            // else It will send an exeption.message that show the error message
            string result = manager.Insert("sp_InsertPatient", name, gender, blood, BD, phone, city);
            if (result == "Failed") 
                MessageBox.Show("Missing Information");
            else if (result == "Succeed") 
                MessageBox.Show("Patient Successfully Seved");
            else  
                MessageBox.Show(result);
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



        public void EditPatient(int ID, string name, string gender, string blood, string BD, string phone, string city)
        {
            Manager manager = new Manager();
            string result = manager.Edit("sp_EditPRowOfId", ID, name, gender, blood, BD, phone, city);

            if (result == "Failed") 
                MessageBox.Show("Missing Information");
            else if (result == "Succeed") 
                MessageBox.Show("Patient is Successfully Updated");
            else 
                MessageBox.Show(result);
        }

        
        public void RemovePatient(int ID, string name, string gender, string blood, string BD, string phone, string city)
        {
            Manager manager = new Manager();
            string result = manager.Delete("sp_DeletePatientRow", ID, name, gender, blood, BD, phone, city);

            if (result == "FailedAll") MessageBox.Show("Select the Patient to Delete");
            else if (result == "Failed") MessageBox.Show("Missing Information");
            else if (result == "Succeed") MessageBox.Show("Patient Successfully Deleted");
            else MessageBox.Show(result);
        }
    }
}
