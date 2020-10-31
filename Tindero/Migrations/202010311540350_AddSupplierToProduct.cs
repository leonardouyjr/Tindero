﻿namespace Tindero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplierToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SupplierId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "SupplierId");
            AddForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "SupplierId" });
            DropColumn("dbo.Products", "SupplierId");
        }
    }
}
