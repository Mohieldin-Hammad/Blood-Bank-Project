using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new loading_page());
            //Application.Run(new login_page());
            //Application.Run(new donor_page());
            //Application.Run(new Patient_Page());    
            //Application.Run(new loading_page());
            Application.Run(new Dashboard());
            //Application.Run(new view_patient());
            //Application.Run(new view_donor());
            // Application.Run(new Transfer());
            //Application.Run(new SignUp());
        }
    }
}
