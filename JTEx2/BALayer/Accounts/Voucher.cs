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
   public class Voucher
    {
        BEL beObj = new BEL();
        DataTable dt = new DataTable();
        dbconnection dbObj = new dbconnection();
        public bool VoucherCreation(BEL beObj)
        {
            return dbObj.CreationAccounts(beObj);
        }
        public DataTable VoucherView(BEL beObj)
        {
            return dbObj.AccountsView(beObj);
        }
        public bool VoucherDeletion(BEL beObj)
        {
            return dbObj.AccountsDeletion(beObj);
        }
        public int VoucherUpdation(BEL beObj)
        {
            return dbObj.AccountsUpdation(beObj);
        }
    }
}
