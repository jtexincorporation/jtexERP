namespace IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DemandGenerates", "Demand_po", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DemandGenerates", "Demand_po", c => c.Int(nullable: false));
        }
    }
}
