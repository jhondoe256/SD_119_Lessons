namespace _14_GeneralStoreAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        SKU = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        QuantityInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SKU);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ProductSKU = c.String(nullable: false, maxLength: 128),
                        ItemCount = c.Int(nullable: false),
                        DateOfTransaction = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductSKU, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductSKU);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "ProductSKU", "dbo.Products");
            DropForeignKey("dbo.Transactions", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "ProductSKU" });
            DropIndex("dbo.Transactions", new[] { "CustomerId" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
        }
    }
}
