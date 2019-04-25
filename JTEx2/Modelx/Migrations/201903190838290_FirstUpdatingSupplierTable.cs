namespace Modelx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstUpdatingSupplierTable : DbMigration
    {
        public override void Up()
        {

            RenameColumn(table: "Suppliers", name: "AccountID", newName: "L4_id");
        }
        
        public override void Down()
        {
            RenameColumn(table: "Suppliers", name: "L4_id", newName: "AccountID");
        }
    }
}
