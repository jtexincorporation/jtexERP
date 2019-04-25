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
  public class Bonus
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool BonusCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }

        public DataTable BonuView(BEL beObj)
        {
            return dbObj.HRView(beObj);
        }

        public bool BonusDeletion(BEL beObj)
        {
            return dbObj.HRDeletion(beObj);
        }

        public int BonusUpdation(BEL beObj)
        {
            return dbObj.HRUpdation(beObj);
        }

    }
}
