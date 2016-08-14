using Autofac;
using SushilaEnterprise.Migrations;
using SushilaEnterprise.Models;
using System.Data.Entity;

namespace SushilaEnterprise
{
    public class DatabaseConfig
    {
        public static void Initialize(IComponentContext componentContext)
        {
            Database.SetInitializer<ApplicationDbContext>(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            using (var dbContext = componentContext.Resolve<DbContext>())
            {
                dbContext.Database.Initialize(false);
            }
        }
    }
}