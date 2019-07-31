namespace BusinessManagementAppDatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplierAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "Code", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Code", c => c.String());
        }
    }
}
