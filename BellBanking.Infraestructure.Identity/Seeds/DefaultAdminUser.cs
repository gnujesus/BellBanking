using BellBanking.Core.Application.Enum;
using BellBanking.Infraestructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace BellBanking.Infraestructure.Identity.Seeds
{
    public static class DefaultAdminUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new();
            defaultUser.UserName = "adminuser";
            defaultUser.Email = "adminuser@bellbanking.com";
            defaultUser.FirstName = "John";
            defaultUser.LastName = "Doe";
            defaultUser.NationalId = "00112345678";
            defaultUser.IsActive =  true;
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word!");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
                }
            }

        }
    }
}
