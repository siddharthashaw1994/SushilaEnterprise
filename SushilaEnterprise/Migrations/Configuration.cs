namespace SushilaEnterprise.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Mvc;

    public sealed class Configuration : DbMigrationsConfiguration<SushilaEnterprise.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SushilaEnterprise.Models.ApplicationDbContext context)
        {
            //var manager = DependencyResolver.Current.GetService<ApplicationUserManager>();
            //var roleManager = DependencyResolver.Current.GetService<ApplicationRoleManager>();

            //if (roleManager.Roles.Count() == 0)
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //if (manager.Users.Count() == 0)
            //{
            //    var user = new ApplicationUser()
            //    {
            //        UserName = "admin@gmail.com",
            //        Email = "admin@gmail.com",
            //    };

            //    manager.Create(user, "Admin@123");

            //    var adminUser = manager.FindByName("admin@gmail.com");

            //    manager.AddToRoles(adminUser.Id, new string[] { "Admin" });
            //}
        }
    }
}
