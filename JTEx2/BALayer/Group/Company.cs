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
   public class Company
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool CompanyCreation(BEL beObj)
        {
            return dbObj.Creation(beObj);
        }

        public DataTable CompanyView(BEL beObj)
        {
            return dbObj.GroupView(beObj);
        }

        public bool CompanyDeletion(BEL beObj)
        {
            return dbObj.Deletion(beObj);
        }

        public int CompanyUpdation(BEL beObj)
        {
            return dbObj.Updation(beObj);
        }
    }
}
