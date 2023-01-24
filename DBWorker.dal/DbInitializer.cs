﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.dal
{
    internal class DbInitializer : IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        public DbInitializer(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _roleManager= roleManager;
            _userManager= userManager;
            _context= context;
        }
        public void Initialize()
        {
            try
            {
                //проверка ожидающих миграцию, если их нет добавить миграцию
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            if (_context.Roles.Any(x => x.Name == "Admin")) return;
            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Manager")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Customer")).GetAwaiter().GetResult();

            var user = new ApplicationUser()
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                Name = "Admin",
                City = "Exigol",
                Address = "Destroyer",
                PostalCode = "666"
            };
            _userManager.CreateAsync(user, "Dark").GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(user, "Admin");

        }
    }
}