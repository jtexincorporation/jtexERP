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
   public class Branchc
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool BranchCreation(BEL beObj)
        {
            return dbObj.Creation(beObj);
        }

        public DataTable BranchView(BEL beObj)
        {
            return dbObj.GroupView(beObj);
        }

        public bool BranchDeletion(BEL beObj)
        {
            return dbObj.Deletion(beObj);
        }

        public int BranchUpdation(BEL beObj)
        {
            return dbObj.Updation(beObj);
        }
    }
}
