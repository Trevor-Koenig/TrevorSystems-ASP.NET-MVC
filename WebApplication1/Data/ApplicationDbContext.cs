using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrevorSystems.Areas.Identity.Data;
using static System.Net.Mime.MediaTypeNames;

namespace TrevorSystems.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public async Task InitializeUsers(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Use by default
            Database.Migrate();

            // Use when creating migrations, it forces the DB to recognize changes
            //Database.EnsureCreated();

            if (!await roleManager.RoleExistsAsync("User"))
                await roleManager.CreateAsync(new IdentityRole("User"));

            if (!await roleManager.RoleExistsAsync("Trusted"))
                await roleManager.CreateAsync(new IdentityRole("Trusted"));

            if (!await roleManager.RoleExistsAsync("TopBanana"))
                await roleManager.CreateAsync(new IdentityRole("TopBanana"));

            if (!await roleManager.RoleExistsAsync("Administrator"))
                await roleManager.CreateAsync(new IdentityRole("Administrator"));

            if (!await userManager.Users.AnyAsync())
            {
                // Make sure there is always an admin account
                User admin = new User();
                Add(admin);
                await userManager.AddToRoleAsync(admin, "Administrator");
                String adminEmail = "admin@trevorsystems.com";
                admin.Email = adminEmail;
                admin.UserName = adminEmail;
                admin.DOB = new DateTime(1, 1, 1);
                admin.highscore1 = admin.highscore2 = admin.highscore3 = admin.highscore4 = admin.highscore5 = ulong.MaxValue;
                admin.NormalizedEmail = adminEmail.Normalize();
                admin.NormalizedUserName = adminEmail.Normalize();
                admin.EmailConfirmed = true;
                await userManager.CreateAsync(admin, "Admin.Password2324");
            }

            SaveChanges();
        }
    }
}