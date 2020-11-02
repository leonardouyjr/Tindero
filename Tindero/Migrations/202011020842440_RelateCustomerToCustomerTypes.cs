namespace Tindero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelateCustomerToCustomerTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "CustomerTypeId");
            AddForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes");
            DropIndex("dbo.Customers", new[] { "CustomerTypeId" });
            DropColumn("dbo.Customers", "CustomerTypeId");
        }
    }
}
