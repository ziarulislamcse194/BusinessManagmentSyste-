namespace BusinessManagementAppDatabaseContext.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BusinessManagementAppDatabaseContext.DatabaseContext.BusinessDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BusinessManagementAppDatabaseContext.DatabaseContext.BusinessDbContext";
        }

        protected override void Seed(BusinessManagementAppDatabaseContext.DatabaseContext.BusinessDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
