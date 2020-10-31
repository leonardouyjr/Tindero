namespace Tindero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductToCustomerOrderDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerOrderDetails", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.CustomerOrderDetails", "ProductId");
            AddForeignKey("dbo.CustomerOrderDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerOrderDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.CustomerOrderDetails", new[] { "ProductId" });
            DropColumn("dbo.CustomerOrderDetails", "ProductId");
        }
    }
}
