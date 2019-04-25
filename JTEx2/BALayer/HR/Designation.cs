using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using BELayer;
using System.Data;

namespace BALayer
{
   public class Designation
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool DesignationCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }

        public DataTable DesignationView(BEL beObj)
        {
            return dbObj.HRView(beObj);
        }

        public bool DesignationDeletion(BEL beObj)
        {
            return dbObj.HRDeletion(beObj);
        }

        public int DesignationUpdation(BEL beObj)
        {
            return dbObj.HRUpdation(beObj);
        }
    }
}
