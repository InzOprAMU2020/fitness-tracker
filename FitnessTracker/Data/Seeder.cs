﻿using FitnessTracker.Helpers;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Data
{
    public static class Seeder
    {
        public static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role {Id = 1, Name = "Admin"},
                new Role {Id = 2, Name = "Moderator"},
                new Role {Id = 3, Name = "User"}
            );
        }

        public static void SeedUsers(ModelBuilder modelBuilder, IAuthHelper authHelper)
        {
            authHelper.CreatePasswordHash("Password#2!",  out byte[] passwordHash, out byte[] passwordSalt);
            
            User adminUser = new User
            {
                Id = 1,
                Email = "admin@gmail.com",
                Name = "Admin Name",
                Surname = "Admin Surname",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleId = 1
            };
            
            User moderatorUser = new User
            {
                Id = 2,
                Email = "moderator@gmail.com",
                Name = "Moderator Name",
                Surname = "Moderator Surname",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleId = 2
            };
            
            User user = new User
            {
                Id = 3,
                Email = "user@gmail.com",
                Name = "User Name",
                Surname = "User Surname",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleId = 3
            };
            
            modelBuilder.Entity<User>().HasData(
                adminUser,
                moderatorUser,
                user
            );
        }
    }
}