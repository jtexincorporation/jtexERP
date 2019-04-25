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
    public class Level3
    {
        BEL beObj = new BEL();
        DataTable dt = new DataTable();
        dbconnection dbObj = new dbconnection();

        public bool Level3Creation(BEL beObj)
        {
            return dbObj.CreationAccounts(beObj);
        }
        public DataTable Level3View(BEL beObj)
        {
            return dbObj.AccountsView(beObj);
        }
        public bool Level3Deletion(BEL beObj)
        {
            return dbObj.AccountsDeletion(beObj);
        }
        public int Level3Updation(BEL beObj)
        {
            return dbObj.AccountsUpdation(beObj);
        }
    }
}
