namespace Modelx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingL5Table : DbMigration
    {
        public override void Up()
        {         
            CreateTable(
                "dbo.Level5",
                  c => new
                  {
                      L5_id = c.Int(nullable: false),
                      L4_id = c.Int(nullable: false),
                      Name = c.String(nullable: false, maxLength: 30, fixedLength: true, unicode: false),
                  })
                .PrimaryKey(t => t.L5_id);          
        }
        
        public override void Down()
        {
            
        }
    }
}
