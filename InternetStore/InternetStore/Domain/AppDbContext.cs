using InternetStore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternetStore.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "8a3f0009-3602-4548-8bcb-4ff4e8420830",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id= "762b0a0d-c46d-4670-abc8-a5c5029b3ec7",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "vegfruit23@gmail.com",
                NormalizedEmail = "VEGFRUIT23@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null,"superpassword"),
                SecurityStamp = string.Empty

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "8a3f0009-3602-4548-8bcb-4ff4e8420830",
                UserId = "762b0a0d-c46d-4670-abc8-a5c5029b3ec7"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id= new Guid("5225d362-5d1c-4ff8-bf4d-e1cd82f91192"),
                CodeWord = "HomePage",
                Title = "Головна",
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("e3104e57-225b-473a-a8fc-8275b7cd662d"),
                CodeWord = "CatalogPage",
                Title = "Каталог",
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("3ebd4da3-48f7-4f17-a876-b800a51d7930"),
                CodeWord = "ContactsPage",
                Title = "Контакти",
            });


        }
    }
}
