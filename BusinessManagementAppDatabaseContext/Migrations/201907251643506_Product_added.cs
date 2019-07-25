namespace BusinessManagementAppDatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product_added : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Catalog_Id", "dbo.Catalogs");
            DropIndex("dbo.Products", new[] { "Catalog_Id" });
            AddColumn("dbo.Products", "Catagory", c => c.String());
            DropColumn("dbo.Products", "CatalogName");
            DropColumn("dbo.Products", "Catalog_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Catalog_Id", c => c.Int());
            AddColumn("dbo.Products", "CatalogName", c => c.String());
            DropColumn("dbo.Products", "Catagory");
            CreateIndex("dbo.Products", "Catalog_Id");
            AddForeignKey("dbo.Products", "Catalog_Id", "dbo.Catalogs", "Id");
        }
    }
}
