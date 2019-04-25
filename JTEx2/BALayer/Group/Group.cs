using BELayer;
using DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class Group
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool GroupCreation(BEL beObj)
        {
            return dbObj.Creation(beObj);
        }

        public DataTable GroupView(BEL beObj)
        {
            return dbObj.GroupView(beObj);
        }

        public bool GroupDeletion(BEL beObj)
        {
            return dbObj.Deletion(beObj);
        }

        public int GroupUpdation(BEL beObj)
        {
            return dbObj.Updation(beObj);
        }
    }
}
