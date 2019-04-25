using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;


namespace BALayer.HR
{
   public class Loan
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool LoanCreation(BEL beObj)
        {
            return dbObj.CreationHR(beObj);
        }

        public DataTable LoanView(BEL beObj)
        {
            return dbObj.HRView(beObj);
        }

        public bool LoanDeletion(BEL beObj)
        {
            return dbObj.HRDeletion(beObj);
        }

        public int LoanUpdation(BEL beObj)
        {
            return dbObj.HRUpdation(beObj);
        }
    }
}
