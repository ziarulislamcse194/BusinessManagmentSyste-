namespace BusinessManagementAppDatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Catalogs", "Code", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "Code", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Code", c => c.String());
            AlterColumn("dbo.Catalogs", "Code", c => c.String());
        }
    }
}
