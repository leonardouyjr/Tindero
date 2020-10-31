namespace Tindero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderToCustomerOrderDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerOrderDetails", "CustomerOrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.CustomerOrderDetails", "CustomerOrderId");
            AddForeignKey("dbo.CustomerOrderDetails", "CustomerOrderId", "dbo.CustomerOrders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerOrderDetails", "CustomerOrderId", "dbo.CustomerOrders");
            DropIndex("dbo.CustomerOrderDetails", new[] { "CustomerOrderId" });
            DropColumn("dbo.CustomerOrderDetails", "CustomerOrderId");
        }
    }
}
