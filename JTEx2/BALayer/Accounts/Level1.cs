using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using System.Data;
using DALayer;

namespace BALayer.Accounts
{
  public  class Level1
    {
        BEL beObj = new BEL();
        DataTable dt = new DataTable();

        dbconnection dbObj = new dbconnection();

        public bool Level1Creation(BEL beObj)
        {
            return dbObj.CreationAccounts(beObj);
        }
        public DataTable Level1View(BEL beObj)
        {
            return dbObj.AccountsView(beObj);
        }
        public bool Level1Deletion(BEL beObj)
        {
            return dbObj.AccountsDeletion(beObj);
        }
        public int Level1Updation(BEL beObj)
        {
            return dbObj.AccountsUpdation(beObj);
        }
    }
}
