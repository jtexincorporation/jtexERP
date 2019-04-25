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
   public class Sellers
    {
        BEL beObj = new BEL();
        DataTable dt = new DataTable();
        dbconnection dbObj = new dbconnection();
        public bool SellersCreation(BEL beObj)
        {
            return dbObj.CreationAccounts(beObj);
        }
        public DataTable SellersView(BEL beObj)
        {
            return dbObj.AccountsView(beObj);
        }
        public bool SellersDeletion(BEL beObj)
        {
            return dbObj.AccountsDeletion(beObj);
        }
        public int SellersUpdation(BEL beObj)
        {
            return dbObj.AccountsUpdation(beObj);
        }
    }
}
