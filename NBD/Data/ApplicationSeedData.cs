using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Data
{
    public class ApplicationSeedData
    {
        public static async Task SeedAsync(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            //Create Roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin","Manager", "Administrative","Desinger", "SalesPerson" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            //Create Users
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            if (userManager.FindByEmailAsync("keri_admin@nbd.ca").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "keri_admin@nbd.ca",
                    Email = "keri_admin@nbd.ca"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
            if (userManager.FindByEmailAsync("cheryl_manager@nbd.ca").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "cheryl_manager@nbd.ca",
                    Email = "cheryl_manager@nbd.ca"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                }
            }
            if (userManager.FindByEmailAsync("desinger@nbd.ca").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "desinger@nbd.ca",
                    Email = "desinger@nbd.ca"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Desingner").Wait();
                }
                
            }

            if (userManager.FindByEmailAsync("administrative@nbd.ca").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "administrative@nbd.ca",
                    Email = "administrative@nbd.ca"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrative").Wait();
                }

            }

            if (userManager.FindByEmailAsync("administrative@nbd.ca").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "administrative@nbd.ca",
                    Email = "administrative@nbd.ca"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrative").Wait();
                }

            }

            if (userManager.FindByEmailAsync("salesperson@nbd.ca").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "salesperson@nbd.ca",
                    Email = "salesperson@nbd.ca"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "SalesPerson").Wait();
                }

            }

            if (userManager.FindByEmailAsync("salesperson@nbd.ca").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "salesperson@nbd.ca",
                    Email = "salesperson@nbd.ca"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "SalesPerson").Wait();
                }

            }
        }
    }
}
