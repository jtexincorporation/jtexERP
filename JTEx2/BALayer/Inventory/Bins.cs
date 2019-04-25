using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BELayer;
using DALayer;


namespace BALayer.Inventory
{
   public class Bins
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();
        DataTable dt = new DataTable();
        public bool BinsCreation(BEL beObj)
        {
            return dbObj.CreationInventory(beObj);
        }

        public DataTable BinsView(BEL beObj)
        {
            return dbObj.InventoryView(beObj);
        }

        public bool BinsDeletion(BEL beObj)
        {
            return dbObj.inventoryDeletion(beObj);
        }
    }
}
