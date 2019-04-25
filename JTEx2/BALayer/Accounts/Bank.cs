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
   public class Bank
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool BankCreation(BEL beObj)
        {
            return dbObj.CreationAccounts(beObj);
        }
        public DataTable BankView(BEL beObj)
        {
            return dbObj.AccountsView(beObj);
        }
        public bool BankDeletion(BEL beObj)
        {
            return dbObj.AccountsDeletion(beObj);
        }
        public int BankUpdation(BEL beObj)
        {
            return dbObj.AccountsUpdation(beObj);
        }
    }
}
