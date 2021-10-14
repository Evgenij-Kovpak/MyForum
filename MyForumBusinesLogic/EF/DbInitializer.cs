using System.Data.Entity;
using FORUM.DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FORUM.DAL.EF
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<ForumDbContext>
    {
        protected override void Seed(ForumDbContext db)
        {
            
            var userManager = new UserManager<User>(new UserStore<User>(db));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            var role1 = new IdentityRole { Name = "Administrator" };
            var role2 = new IdentityRole { Name = "Moderator" };
            var role3 = new IdentityRole { Name = "User" };
         

            roleManager.Create(role1);
            roleManager.Create(role2);
            roleManager.Create(role3);
         

            string password = "123Qwerty";

            var adminUser = new User() { Email = "admin@forum.com", UserName = "Administrator"};
            var moderatorUser = new User() { Email = "moderator@forum.com", UserName = "Moderator" };
            var userUser = new User() { Email = "user@forum.com", UserName = "User" };

            var result1 = userManager.Create(adminUser, password);
            var result2 = userManager.Create(moderatorUser, password);
            var result3 = userManager.Create(userUser, password);
 

            if (result1.Succeeded)
            {
                userManager.AddToRole(adminUser.Id, role1.Name);
                userManager.AddToRole(adminUser.Id, role2.Name);
                userManager.AddToRole(adminUser.Id, role3.Name);
            }
            if (result2.Succeeded)
            {
                userManager.AddToRole(moderatorUser.Id, role2.Name);
                userManager.AddToRole(moderatorUser.Id, role3.Name);
            }
            if (result3.Succeeded)
            {
                userManager.AddToRole(userUser.Id, role3.Name);
            }

            db.SaveChanges();
        }

    }
}
