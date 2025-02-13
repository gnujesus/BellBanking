﻿using BellBanking.Core.Application.Enum;
using BellBanking.Infraestructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellBanking.Infraestructure.Identity.Seeds
{
    public static class DefaultCustomerUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new();
            defaultUser.UserName = "customeruser";
            defaultUser.Email = "customeruser@bellbanking.com";
            defaultUser.FirstName = "Jane";
            defaultUser.LastName = "Doe";
            defaultUser.NationalId = "40212345678";
            defaultUser.IsActive = true;
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word!");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Customer.ToString());
                }
            }

        }
    }
}
