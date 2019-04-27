namespace IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtableInventory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YarnStocks",
                c => new
                    {
                        StoreID = c.Int(nullable: false, identity: true),
                        YarnID = c.Int(nullable: false),
                        Yarn_Po = c.String(),
                        PartyID = c.Int(nullable: false),
                        YarnsBags = c.Int(nullable: false),
                        yarnGatepass = c.Int(nullable: false),
                        GP_Category = c.String(),
                        YarnNetweighy = c.Single(nullable: false),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Category = c.String(),
                        Amount = c.Int(nullable: false),
                        DriverName = c.String(),
                        VehicleNumber = c.Int(nullable: false),
                        Department = c.String(),
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StoreID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YarnStocks");
        }
    }
}
