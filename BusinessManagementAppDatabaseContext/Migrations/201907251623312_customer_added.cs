namespace BusinessManagementAppDatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer_added : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "ContactNo", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "LoyaltyPoint", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "LoyaltyPoint", c => c.Double(nullable: false));
            AlterColumn("dbo.Customers", "ContactNo", c => c.Double(nullable: false));
        }
    }
}
