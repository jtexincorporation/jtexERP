namespace IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDemandTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DemandGenerates",
                c => new
                    {
                        Demand_id = c.Int(nullable: false, identity: true),
                        Demand_po = c.Int(nullable: false),
                        Demand_yarnID = c.Int(nullable: false),
                        Demand_Bags = c.Int(nullable: false),
                        Demand_netWeight = c.Int(nullable: false),
                        Demand_GtWeight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Demand_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DemandGenerates");
        }
    }
}
