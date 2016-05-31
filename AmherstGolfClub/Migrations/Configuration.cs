namespace AmherstGolfClub.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
            ContextKey = "AmherstGolfClub.Models.ApplicationDbContext";
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            // seeding identity with role and admin users
            //add admin roll
            if (!(context.Roles.Any(r => r.Name == "admin")))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var roleToInsert = new IdentityRole { Name = "admin" };
                roleManager.Create(roleToInsert);
            }
            //add student
            if (!(context.Roles.Any(r => r.Name == "member")))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var roleToInsert = new IdentityRole { Name = "member" };
                roleManager.Create(roleToInsert);
            }
            //add instructor
            if (!(context.Roles.Any(r => r.Name == "guest")))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var roleToInsert = new IdentityRole { Name = "guest" };
                roleManager.Create(roleToInsert);
            }
            //add admin user assign admin role
            if (!(context.Users.Any(r => r.UserName == "greglaurette@gmail.com" || r.UserName == "archibaldmichael@hotmail.com")))
            {
                var userStore = new UserStore<Models.ApplicationUser>(context);
                var userManager = new UserManager<Models.ApplicationUser>(userStore);
                var userToInsert = new Models.ApplicationUser { UserName = "greglaurette@gmail.com", Email = "greglaurette@gmail.com", EmailConfirmed = true };
                userManager.Create(userToInsert, "Administrator");
                userManager.AddToRole(userToInsert.Id, "admin");
            }
        }
    }
}
