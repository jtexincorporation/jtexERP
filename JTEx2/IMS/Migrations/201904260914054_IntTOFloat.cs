namespace IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntTOFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DemandGenerates", "Demand_netWeight", c => c.Single(nullable: false));
            AlterColumn("dbo.DemandGenerates", "Demand_GtWeight", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DemandGenerates", "Demand_GtWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.DemandGenerates", "Demand_netWeight", c => c.Int(nullable: false));
        }
    }
}
