namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiscountProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Discount = c.String(),
                        Products_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Products_ID)
                .Index(t => t.Products_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        BasePrice = c.Double(nullable: false),
                        Tax = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Invoices_ID = c.Int(),
                        Products_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Invoices", t => t.Invoices_ID)
                .ForeignKey("dbo.Products", t => t.Products_ID)
                .Index(t => t.Invoices_ID)
                .Index(t => t.Products_ID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IssuerName = c.String(),
                        ReceiverName = c.String(),
                        IssueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "Products_ID", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "Invoices_ID", "dbo.Invoices");
            DropForeignKey("dbo.DiscountProducts", "Products_ID", "dbo.Products");
            DropIndex("dbo.OrderItems", new[] { "Products_ID" });
            DropIndex("dbo.OrderItems", new[] { "Invoices_ID" });
            DropIndex("dbo.DiscountProducts", new[] { "Products_ID" });
            DropTable("dbo.Invoices");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Products");
            DropTable("dbo.DiscountProducts");
        }
    }
}
