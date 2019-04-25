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
   public class Products
    {
        BEL beObj = new BEL();
        dbconnection dbObj = new dbconnection();
        DataTable dt = new DataTable();
        public bool ProductCreation(BEL beObj)
        {
            return dbObj.CreationInventory(beObj);
        }

        public DataTable ProductView(BEL beObj)
        {
            return dbObj.InventoryView(beObj);
        }

        public bool ProductDeletion(BEL beObj)
        {
            return dbObj.inventoryDeletion(beObj);
        }
    }
}
