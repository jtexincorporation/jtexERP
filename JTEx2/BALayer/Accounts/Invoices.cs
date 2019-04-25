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
    public class Invoices
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();
        public bool GLCreation(BEL beObj)
        {
            return dbObj.CreationAccounts(beObj);
        }
        public DataTable GLView(BEL beObj)
        {
            return dbObj.AccountsView(beObj);
        }
    }
}
