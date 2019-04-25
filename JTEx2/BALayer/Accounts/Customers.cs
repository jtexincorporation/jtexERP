using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;
using System.Data;

namespace BALayer.Accounts
{
   public class Customers
    {
        BEL beObj = new BEL();
        DataTable dt = new DataTable();
        dbconnection dbObj = new dbconnection();
        public bool CustomerCreation(BEL beObj)
        {
            return dbObj.CreationAccounts(beObj);
        }
        public DataTable CustomerView(BEL beObj)
        {
            return dbObj.AccountsView(beObj);
        }
        public bool CustomerDeletion(BEL beObj)
        {
            return dbObj.AccountsDeletion(beObj);
        }
        public int CustomerUpdation(BEL beObj)
        {
            return dbObj.AccountsUpdation(beObj);
        }
    }
}
