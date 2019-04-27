namespace IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialIMS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.yDefines",
                c => new
                    {
                        Yarn_id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Count = c.String(),
                        BrandName = c.String(),
                        L4_id = c.Int(nullable: false),
                        ItemType = c.String(),
                        isActive = c.String(),
                    })
                .PrimaryKey(t => t.Yarn_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.yDefines");
        }
    }
}
