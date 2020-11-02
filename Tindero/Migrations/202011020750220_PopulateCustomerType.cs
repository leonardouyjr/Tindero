namespace Tindero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerType : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT CustomerTypes ON;");

            Sql("INSERT INTO CustomerTypes(Id, Name) VALUES(1,'WalkIn')");
            Sql("INSERT INTO CustomerTypes(Id, Name) VALUES(2,'Regular')");
            Sql("INSERT INTO CustomerTypes(Id, Name) VALUES(3,'Silver')");
            Sql("INSERT INTO CustomerTypes(Id, Name) VALUES(4,'Gold')");

            Sql("SET IDENTITY_INSERT CustomerTypes OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
