namespace Tindero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 128));
        }
    }
}
