namespace BusinessManagementAppDatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Code", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Code", c => c.String());
        }
    }
}
