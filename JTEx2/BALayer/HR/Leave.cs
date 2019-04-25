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
   public class Leave
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool LeaveCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }

        public DataTable LeaveView(BEL beObj)
        {
            return dbObj.HRView(beObj);
        }

        public bool LeaveDeletion(BEL beObj)
        {
            return dbObj.HRDeletion(beObj);
        }

        public int LeaveUpdation(BEL beObj)
        {
            return dbObj.HRUpdation(beObj);
        }
        public int AvailableLeave(BEL beObj)
        {
            return dbObj.ConstraintAvailableDays(beObj);
        }
        public int AvailableLeaveInLeaveBalance(BEL beObj)
        {
            return dbObj.AvailableDaysInLeaveBalance(beObj);
        }
        public bool UpdateLeavseInLeaveBalance(BEL beObj)
        {
            return dbObj.UpdateDaysinLeaveBalance(beObj);
        }
    }
}
