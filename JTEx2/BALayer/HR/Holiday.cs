using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;

namespace BALayer
{
   public class Holiday
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool HolidayCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }

        public DataTable HolidayView(BEL beObj)
        {
            return dbObj.HRView(beObj);
        }

        public bool HolidayDeletion(BEL beObj)
        {
            return dbObj.HRDeletion(beObj);
        }

        public int HolidayUpdation(BEL beObj)
        {
            return dbObj.HRUpdation(beObj);
        }
    }
}
