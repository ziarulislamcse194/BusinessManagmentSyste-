namespace BusinessManagementAppDatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catalogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        ContactNo = c.Double(nullable: false),
                        LoyaltyPoint = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        ReorderLevel = c.Double(nullable: false),
                        Description = c.String(),
                        CatalogName = c.String(),
                        Catalog_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Catalogs", t => t.Catalog_Id)
                .Index(t => t.Catalog_Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.Double(nullable: false),
                        ContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Catalog_Id", "dbo.Catalogs");
            DropIndex("dbo.Products", new[] { "Catalog_Id" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
            DropTable("dbo.Catalogs");
        }
    }
}
