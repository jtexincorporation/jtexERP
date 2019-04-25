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
  public class Department
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool DepartmentCreation(BEL beObj)
        {
            return dbObj.Creation(beObj);
        }

        public DataTable DepartmentView(BEL beObj)
        {
            return dbObj.GroupView(beObj);
        }

        public bool DepartmentDeletion(BEL beObj)
        {
            return dbObj.Deletion(beObj);
        }

        public int DepartmentUpdation(BEL beObj)
        {
            return dbObj.Updation(beObj);
        }
    }
}
