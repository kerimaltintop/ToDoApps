using KerimProje.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KerimProje.ToDo.WebUI
{
    public static class IdentityInitializer
    {
        public static async System.Threading.Tasks.Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole
                {
                    Name = "Admin"
                });
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole
                {
                    Name = "Member"
                });
            }

            var adminUser = await userManager.FindByNameAsync("kerim");
            if (adminUser == null)
            {
                AppUser user = new AppUser
                {
                    Name = "kerim",
                    Surname = "altıntop",
                    UserName = "kerim",
                    Email = "kerimaltintop@gmail.com"
                };
                await userManager.CreateAsync(user, "123456");
                await userManager.AddToRoleAsync(user, "Admin");
            }


        }
    }
}
