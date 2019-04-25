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
    public class ProductUnit
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();
        DataTable dt = new DataTable();
        public bool ProductUnitCreation(BEL beObj)
        {
            return dbObj.CreationInventory(beObj);
        }

        public DataTable ProductUnitView(BEL beObj)
        {
            return dbObj.InventoryView(beObj);
        }

        public bool ProductUnitDeletion(BEL beObj)
        {
            return dbObj.inventoryDeletion(beObj);
        }
    }
}
