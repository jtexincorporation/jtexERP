using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using BALayer;
using System.Data;
using DALayer;

namespace BALayer.Accounts
{
    public class Level2
    {
        BEL beObj = new BEL();
        DataTable dt = new DataTable();
        dbconnection dbObj = new dbconnection();
        public bool Level2Creation(BEL beObj)
        {
            return dbObj.CreationAccounts(beObj);
        }
        public DataTable Level2View(BEL beObj)
        {
            return dbObj.AccountsView(beObj);
        }
        public bool Level2Deletion(BEL beObj)
        {
            return dbObj.AccountsDeletion(beObj);
        }
        public int Level2Updation(BEL beObj)
        {
            return dbObj.AccountsUpdation(beObj);
        }
    }
}
