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
   public class shifts
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool ShiftCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }

        public DataTable ShiftView(BEL beObj)
        {
            return dbObj.HRView(beObj);
        }

        public bool ShiftDeletion(BEL beObj)
        {
            return dbObj.HRDeletion(beObj);
        }

        public int ShiftUpdation(BEL beObj)
        {
            return dbObj.HRUpdation(beObj);
        }
    }
}
