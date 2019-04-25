using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;

namespace BALayer.HR
{
   public class Increment
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool IncrementCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }

        public DataTable IncrementView(BEL beObj)
        {
            return dbObj.HRView(beObj);
        }

        public bool IncrementDeletion(BEL beObj)
        {
            return dbObj.HRDeletion(beObj);
        }

        public int IncrementUpdation(BEL beObj)
        {
            return dbObj.HRUpdation(beObj);
        }
        public bool UpdateEmployeSalary(BEL beObj)
        {
            return dbObj.UpdateEmployeSalary(beObj);
        }
    }
}
