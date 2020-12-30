using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAEmlak.Data;

namespace FAEmlak.Identity
{
    public static class SeedUsers
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {

            if (await userManager.FindByNameAsync("g181210106@sakarya.edu.tr") == null && await userManager.FindByNameAsync("b181210091@sakarya.edu.tr") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
                await roleManager.CreateAsync(new IdentityRole("User"));

                var AlperenAdmin = new User()
                {
                    UserName = "g181210106@sakarya.edu.tr",
                    Email = "g181210106@sakarya.edu.tr",
                    FirstName = "Alperen",
                    LastName = "Derin",
                    EmailConfirmed = true
                };

                var FurkanAdmin = new User()
                {
                    UserName = "b181210091@sakarya.edu.tr",
                    Email = "b181210091@sakarya.edu.tr",
                    FirstName = "Furkan",
                    LastName = "Ergün",
                    EmailConfirmed = true
                };

                var user = new User
                {
                    UserName = "fakullanici",
                    Email = "fa@fakullanici.com",
                    FirstName = "user",
                    LastName = "user",
                    EmailConfirmed = true
                };
                var userResult = await userManager.CreateAsync(user, "123");
                if (userResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User");
                }

                var AlperenResult = await userManager.CreateAsync(AlperenAdmin, "123");
                if (AlperenResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(AlperenAdmin, "Admin");
                }

                var FurkanResult = await userManager.CreateAsync(FurkanAdmin, "123");
                if (FurkanResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(FurkanAdmin, "Admin");
                }
            }
        }
    }
}
