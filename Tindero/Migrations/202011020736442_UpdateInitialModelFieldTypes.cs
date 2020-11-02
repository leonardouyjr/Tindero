namespace Tindero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateInitialModelFieldTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerOrders", "Description", c => c.String(maxLength: 255));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProductCategories", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProductCategories", "Description", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Suppliers", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Suppliers", "ContactTitle", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Suppliers", "ContactName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Suppliers", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Suppliers", "Barangay", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Suppliers", "City", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Suppliers", "Country", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Suppliers", "PostalCode", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Suppliers", "ContactNumber", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Suppliers", "EmailAddress", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Suppliers", "WebsiteURL", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 128));
            AlterColumn("dbo.CustomerTypes", "Name", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerTypes", "Name", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            AlterColumn("dbo.Suppliers", "WebsiteURL", c => c.String());
            AlterColumn("dbo.Suppliers", "EmailAddress", c => c.String());
            AlterColumn("dbo.Suppliers", "ContactNumber", c => c.String());
            AlterColumn("dbo.Suppliers", "PostalCode", c => c.String());
            AlterColumn("dbo.Suppliers", "Country", c => c.String());
            AlterColumn("dbo.Suppliers", "City", c => c.String());
            AlterColumn("dbo.Suppliers", "Barangay", c => c.String());
            AlterColumn("dbo.Suppliers", "Address", c => c.String());
            AlterColumn("dbo.Suppliers", "ContactName", c => c.String());
            AlterColumn("dbo.Suppliers", "ContactTitle", c => c.String());
            AlterColumn("dbo.Suppliers", "Name", c => c.String());
            AlterColumn("dbo.ProductCategories", "Description", c => c.String());
            AlterColumn("dbo.ProductCategories", "Name", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.CustomerOrders", "Description", c => c.String());
        }
    }
}
