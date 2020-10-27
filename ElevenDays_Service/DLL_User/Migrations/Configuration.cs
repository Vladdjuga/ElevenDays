namespace DLL_User.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DLL_User.Model_Users>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DLL_User.Model_Users";
        }

        protected override void Seed(DLL_User.Model_Users context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
