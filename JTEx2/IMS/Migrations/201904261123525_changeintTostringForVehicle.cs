namespace IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeintTostringForVehicle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.YarnStocks", "VehicleNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.YarnStocks", "VehicleNumber", c => c.Int(nullable: false));
        }
    }
}
