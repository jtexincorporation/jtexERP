using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using BELayer;
using System.Data;

namespace BALayer.HR
{
   public class LeaveBalance
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool LeaveBalanceCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }

        public DataTable LeaveBalanceView(BEL beObj)
        {
            return dbObj.HRView(beObj);
        }

        public bool LeaveBalanceDeletion(BEL beObj)
        {
            return dbObj.HRDeletion(beObj);
        }

        public int LeaveBalanceUpdation(BEL beObj)
        {
            return dbObj.HRUpdation(beObj);
        }
    }
}
