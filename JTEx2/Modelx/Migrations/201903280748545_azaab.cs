namespace Modelx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class azaab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorID = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ColorID);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        StyleNumber = c.String(nullable: false, maxLength: 50),
                        PriceBy = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 200),
                        Gender = c.Byte(nullable: false),
                        Color = c.Byte(nullable: false),
                        Comp = c.String(maxLength: 50),
                        Weight = c.Double(),
                        Price = c.Decimal(storeType: "money"),
                        Currency = c.Byte(),
                        PicturePath = c.String(unicode: false, storeType: "text"),
                        isActive = c.Boolean(nullable: false),
                        Brand = c.Byte(nullable: false),
                        Brand1_BrandID = c.Byte(),
                        Color1_ColorID = c.Byte(),
                        Currency1_CurrencyID = c.Byte(),
                        Gender1_GenderID = c.Byte(),
                        Size_SizeID = c.Byte(),
                    })
                .PrimaryKey(t => t.ArticleID)
                .ForeignKey("dbo.Brand", t => t.Brand1_BrandID)
                .ForeignKey("dbo.Colors", t => t.Color1_ColorID)
                .ForeignKey("dbo.Currency", t => t.Currency1_CurrencyID)
                .ForeignKey("dbo.Gender", t => t.Gender1_GenderID)
                .ForeignKey("dbo.Size", t => t.Size_SizeID)
                .Index(t => t.Brand1_BrandID)
                .Index(t => t.Color1_ColorID)
                .Index(t => t.Currency1_CurrencyID)
                .Index(t => t.Gender1_GenderID)
                .Index(t => t.Size_SizeID);
            
            CreateTable(
                "dbo.ArticleStatus",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        doc = c.Long(nullable: false),
                        po = c.String(nullable: false, maxLength: 50),
                        articleid = c.Int(nullable: false),
                        statusid = c.Byte(nullable: false),
                        remarks = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Articles", t => t.articleid, cascadeDelete: true)
                .Index(t => t.articleid);
            
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        BrandID = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BrandID);
            
            CreateTable(
                "dbo.Currency",
                c => new
                    {
                        CurrencyID = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CurrencyID);
            
            CreateTable(
                "dbo.Gender",
                c => new
                    {
                        GenderID = c.Byte(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GenderID);
            
            CreateTable(
                "dbo.PurchaseOrders",
                c => new
                    {
                        doc = c.Decimal(nullable: false, precision: 18, scale: 2, storeType: "numeric"),
                        id = c.Decimal(nullable: false, precision: 18, scale: 2, storeType: "numeric"),
                        date = c.DateTime(nullable: false, storeType: "date"),
                        po = c.String(nullable: false, maxLength: 20),
                        client = c.Int(nullable: false),
                        articleid = c.Int(nullable: false),
                        qty = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        packing = c.String(maxLength: 50),
                        ticketing = c.String(maxLength: 50),
                        paymentterm = c.String(maxLength: 50),
                        polybag = c.String(maxLength: 50),
                        priceby = c.String(maxLength: 50),
                        season = c.Byte(),
                        delivery = c.DateTime(storeType: "date"),
                        remarks = c.String(maxLength: 200),
                        status = c.Byte(),
                        Client1_clientid = c.Int(),
                        Season1_SeasonID = c.Byte(),
                    })
                .PrimaryKey(t => new { t.doc, t.id, t.date, t.po, t.client, t.articleid, t.qty, t.price })
                .ForeignKey("dbo.Articles", t => t.articleid, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client1_clientid)
                .ForeignKey("dbo.Seasons", t => t.Season1_SeasonID)
                .Index(t => t.articleid)
                .Index(t => t.Client1_clientid)
                .Index(t => t.Season1_SeasonID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        clientid = c.Int(nullable: false),
                        L4_id = c.Int(),
                        name = c.String(nullable: false, maxLength: 50),
                        address = c.String(maxLength: 50),
                        contact = c.String(maxLength: 50),
                        email = c.String(maxLength: 50),
                        web = c.String(maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.clientid);
            
            CreateTable(
                "dbo.LoginSecurity",
                c => new
                    {
                        loginid = c.Byte(nullable: false, identity: true),
                        username = c.String(nullable: false, maxLength: 50),
                        password = c.String(nullable: false, maxLength: 50),
                        logintype = c.String(nullable: false, maxLength: 15),
                        clientid = c.Int(),
                        isactive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.loginid)
                .ForeignKey("dbo.Clients", t => t.clientid)
                .Index(t => t.clientid);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        SeasonID = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SeasonID);
            
            CreateTable(
                "dbo.Size",
                c => new
                    {
                        SizeID = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 50),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SizeID);
            
            CreateTable(
                "dbo.ArticleBarcode",
                c => new
                    {
                        id = c.Short(nullable: false),
                        articleid = c.Int(nullable: false),
                        sizeid = c.Byte(nullable: false),
                        qty = c.Short(),
                        barcode = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.id, t.articleid, t.sizeid })
                .ForeignKey("dbo.Size", t => t.sizeid, cascadeDelete: true)
                .Index(t => t.sizeid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "Size_SizeID", "dbo.Size");
            DropForeignKey("dbo.ArticleBarcode", "sizeid", "dbo.Size");
            DropForeignKey("dbo.PurchaseOrders", "Season1_SeasonID", "dbo.Seasons");
            DropForeignKey("dbo.PurchaseOrders", "Client1_clientid", "dbo.Clients");
            DropForeignKey("dbo.LoginSecurity", "clientid", "dbo.Clients");
            DropForeignKey("dbo.PurchaseOrders", "articleid", "dbo.Articles");
            DropForeignKey("dbo.Articles", "Gender1_GenderID", "dbo.Gender");
            DropForeignKey("dbo.Articles", "Currency1_CurrencyID", "dbo.Currency");
            DropForeignKey("dbo.Articles", "Color1_ColorID", "dbo.Colors");
            DropForeignKey("dbo.Articles", "Brand1_BrandID", "dbo.Brand");
            DropForeignKey("dbo.ArticleStatus", "articleid", "dbo.Articles");
            DropIndex("dbo.ArticleBarcode", new[] { "sizeid" });
            DropIndex("dbo.LoginSecurity", new[] { "clientid" });
            DropIndex("dbo.PurchaseOrders", new[] { "Season1_SeasonID" });
            DropIndex("dbo.PurchaseOrders", new[] { "Client1_clientid" });
            DropIndex("dbo.PurchaseOrders", new[] { "articleid" });
            DropIndex("dbo.ArticleStatus", new[] { "articleid" });
            DropIndex("dbo.Articles", new[] { "Size_SizeID" });
            DropIndex("dbo.Articles", new[] { "Gender1_GenderID" });
            DropIndex("dbo.Articles", new[] { "Currency1_CurrencyID" });
            DropIndex("dbo.Articles", new[] { "Color1_ColorID" });
            DropIndex("dbo.Articles", new[] { "Brand1_BrandID" });
            DropTable("dbo.ArticleBarcode");
            DropTable("dbo.Size");
            DropTable("dbo.Seasons");
            DropTable("dbo.LoginSecurity");
            DropTable("dbo.Clients");
            DropTable("dbo.PurchaseOrders");
            DropTable("dbo.Gender");
            DropTable("dbo.Currency");
            DropTable("dbo.Brand");
            DropTable("dbo.ArticleStatus");
            DropTable("dbo.Articles");
            DropTable("dbo.Colors");
        }
    }
}
