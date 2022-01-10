using System;
using System.Threading.Tasks;
using AuthenticationApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticationApi.Data
{
    public class IdentitySeedData
    {
        public static void CreateAdminAccount(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            CreateAdminAccountAsync(serviceProvider, configuration).Wait();
        }

        public static async Task CreateAdminAccountAsync(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                serviceProvider = scope.ServiceProvider;
                UserManager<User> userManager = serviceProvider.GetRequiredService<UserManager<User>>();
                RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                string userName = configuration["Data:AdminUser:UserName"] ?? "Admin";
                string email = configuration["Data:AdminUser:Email"] ?? "admin.shining@gmail.com";
                string password = configuration["Data:AdminUser:Password"] ?? "";
                string role = configuration["Data:AdminUser:Role"] ?? "Administrator";
                string userRole = "User";

                if (await userManager.FindByNameAsync(userName) == null)
                {
                    if (await roleManager.FindByNameAsync(role) == null)
                    {
                        await roleManager.CreateAsync(new IdentityRole(role));
                    }

                    if (await roleManager.FindByNameAsync(userRole) == null)
                    {
                        await roleManager.CreateAsync(new IdentityRole(userRole));
                    }

                    User user = new User
                    {
                        UserName = userName,
                        Email = email
                    };

                    IdentityResult result = await userManager.CreateAsync(user, password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, role);
                    }
                }
            }

        }
    }
}