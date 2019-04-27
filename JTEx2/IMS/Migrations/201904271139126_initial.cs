namespace IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DemandGenerates",
                c => new
                    {
                        Demand_id = c.Int(nullable: false, identity: true),
                        Demand_po = c.String(nullable: false, maxLength: 20),
                        Demand_yarnID = c.Int(nullable: false),
                        Demand_Bags = c.Int(nullable: false),
                        Demand_netWeight = c.Single(nullable: false),
                        Demand_GtWeight = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Demand_id);
            
            CreateTable(
                "dbo.YarnStocks",
                c => new
                    {
                        StoreID = c.Int(nullable: false, identity: true),
                        YarnID = c.Int(nullable: false),
                        Yarn_Po = c.String(nullable: false, maxLength: 20),
                        PartyID = c.Int(nullable: false),
                        YarnsBags = c.Int(nullable: false),
                        yarnGatepass = c.Int(nullable: false),
                        GP_Category = c.String(nullable: false, maxLength: 20),
                        YarnNetweighy = c.Single(nullable: false),
                        Description = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Category = c.String(nullable: false, maxLength: 20),
                        Amount = c.Int(nullable: false),
                        DriverName = c.String(nullable: false, maxLength: 50),
                        VehicleNumber = c.String(nullable: false, maxLength: 20),
                        Department = c.String(nullable: false, maxLength: 20),
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StoreID);
            
            CreateTable(
                "dbo.yDefines",
                c => new
                    {
                        Yarn_id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 20),
                        Count = c.String(nullable: false, maxLength: 20),
                        BrandName = c.String(nullable: false, maxLength: 20),
                        L4_id = c.Int(nullable: false),
                        ItemType = c.String(nullable: false, maxLength: 20),
                        isActive = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Yarn_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.yDefines");
            DropTable("dbo.YarnStocks");
            DropTable("dbo.DemandGenerates");
        }
    }
}
