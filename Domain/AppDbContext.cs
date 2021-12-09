using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Company.Domain.Entities;

namespace Company.Domain
{
    //
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "a11344dd-aed2-4a7b-8a76-073ab977b59f",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "0eb497a3-24a1-4fb4-8948-6b922e756bf2",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@company.com",
                NormalizedEmail = "ADMIN@COMPANY.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "a11344dd-aed2-4a7b-8a76-073ab977b59f",
                UserId = "0eb497a3-24a1-4fb4-8948-6b922e756bf2"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("1a9b3f54-d442-4e8f-afd9-80a704764fb9"),
                CodeWord = "PageIndex",
                Title = "Главная страница"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("7af6dc8c-199b-4173-b311-16e65e588bd9"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("cb5d6de2-9b95-4432-be1d-d1e8a689111c"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
            
        }
    }
}
