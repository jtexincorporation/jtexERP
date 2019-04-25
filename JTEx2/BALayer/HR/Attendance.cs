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
    public class Attendance
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();
        DataTable dt = new DataTable();
        
        public bool CheckattendanceExist(BEL beObj)
        {
            return dbObj.CheckAttendanceExist(beObj);
        }

        public DataTable GetAttendanceRecordOfEmployee(BEL beObj)
        {
            return dbObj.EmployeeAttendanceView(beObj);
        }
        public bool updateTimeOut(BEL beObj)
        {
            return dbObj.EmployeUpdateTimeOutAttendance(beObj);
        }
        public bool AttendanceCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }
    }
}
