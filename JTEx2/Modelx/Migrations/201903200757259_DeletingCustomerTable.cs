namespace Modelx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingCustomerTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(),
                        Name = c.String(maxLength: 50, unicode: false),
                        Category = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 100, unicode: false),
                        ContactPerson = c.String(maxLength: 30, unicode: false),
                        PhoneNumber = c.String(maxLength: 30, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
    }
}
