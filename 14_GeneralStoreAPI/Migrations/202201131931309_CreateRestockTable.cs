namespace _14_GeneralStoreAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRestockTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestockLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductSKU = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DateOfRestock = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RestockLogs");
        }
    }
}
