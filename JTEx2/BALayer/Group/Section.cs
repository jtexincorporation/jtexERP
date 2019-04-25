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
   public class Section
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();

        public bool SectionCreation(BEL beObj)
        {
            return dbObj.Creation(beObj);
        }

        public DataTable SectionView(BEL beObj)
        {
            return dbObj.GroupView(beObj);
        }

        public bool SectionDeletion(BEL beObj)
        {
            return dbObj.Deletion(beObj);
        }

        public int SectionUpdation(BEL beObj)
        {
            return dbObj.Updation(beObj);
        }
    }
}
