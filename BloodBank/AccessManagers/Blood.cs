using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BloodBank.AccessManagers
{
    internal class Blood : Manager
    {
        public DataTable ShowPatients()
        {
            Manager manager = new Manager();
            
            return manager.Select("sp_ShowBloodsTable");
        }
    }
}
