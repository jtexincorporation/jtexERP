namespace IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databaseChanging : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DemandGenerates", "Demand_po", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.YarnStocks", "Yarn_Po", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.YarnStocks", "GP_Category", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.YarnStocks", "Description", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.YarnStocks", "Category", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.YarnStocks", "DriverName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.YarnStocks", "VehicleNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.YarnStocks", "Department", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.yDefines", "Type", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.yDefines", "Count", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.yDefines", "BrandName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.yDefines", "ItemType", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.yDefines", "isActive", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.yDefines", "isActive", c => c.String());
            AlterColumn("dbo.yDefines", "ItemType", c => c.String());
            AlterColumn("dbo.yDefines", "BrandName", c => c.String());
            AlterColumn("dbo.yDefines", "Count", c => c.String());
            AlterColumn("dbo.yDefines", "Type", c => c.String());
            AlterColumn("dbo.YarnStocks", "Department", c => c.String());
            AlterColumn("dbo.YarnStocks", "VehicleNumber", c => c.String());
            AlterColumn("dbo.YarnStocks", "DriverName", c => c.String());
            AlterColumn("dbo.YarnStocks", "Category", c => c.String());
            AlterColumn("dbo.YarnStocks", "Description", c => c.String());
            AlterColumn("dbo.YarnStocks", "GP_Category", c => c.String());
            AlterColumn("dbo.YarnStocks", "Yarn_Po", c => c.String());
            AlterColumn("dbo.DemandGenerates", "Demand_po", c => c.String());
        }
    }
}
