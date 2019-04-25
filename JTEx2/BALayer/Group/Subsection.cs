using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;

namespace BALayer
{
    public class Subsection
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool SubectionCreation(BEL beObj)
        {
            return dbObj.Creation(beObj);
        }

        public DataTable SubectionView(BEL beObj)
        {
            return dbObj.GroupView(beObj);
        }

        public bool SubectionDeletion(BEL beObj)
        {
            return dbObj.Deletion(beObj);
        }

        public int SubectionUpdation(BEL beObj)
        {
            return dbObj.Updation(beObj);
        }
    }
}
