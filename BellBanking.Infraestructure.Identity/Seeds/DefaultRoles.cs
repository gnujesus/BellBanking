﻿using BellBanking.Core.Application.Enum;
using BellBanking.Infraestructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace BellBanking.Infraestructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Customer.ToString()));
        }
    }
}
