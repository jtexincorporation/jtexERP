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
   public class Unit
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool UnitCreation(BEL beObj)
        {
            return dbObj.Creation(beObj);
        }

        public DataTable UnitView(BEL beObj)
        {
            return dbObj.GroupView(beObj);
        }

        public bool UnitDeletion(BEL beObj)
        {
            return dbObj.Deletion(beObj);
        }

        public int UnitUpdation(BEL beObj)
        {
            return dbObj.Updation(beObj);
        }
    }
}
