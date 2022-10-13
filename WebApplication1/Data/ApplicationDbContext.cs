using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public async Task InitializeUsers(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            Database.Migrate();

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
                IdentityUser admin = new IdentityUser();
                Add(admin);
                await userManager.AddToRoleAsync(admin, "Administrator");
                String adminEmail = "admin@trevorsystems.com";
                admin.Email = adminEmail;
                admin.UserName = adminEmail;
                admin.NormalizedEmail = adminEmail.Normalize();
                admin.NormalizedUserName = adminEmail.Normalize();
                admin.EmailConfirmed = true;
                await userManager.CreateAsync(admin, "Tjcarrottop01");
            }

            SaveChanges();
        }
    }
}