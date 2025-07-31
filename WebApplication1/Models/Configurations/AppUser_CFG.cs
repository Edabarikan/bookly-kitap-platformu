using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.Configurations
{
    public class AppUser_CFG : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            AppUser user = new AppUser()
            {
                Id = 1,
                Ad = "Super",
                Soyad = "User",
                Adres = "Turkiye",
                UserName = "superUser",
                NormalizedUserName = "SUPERUSER",
                Email = "super@deneme.com",
                NormalizedEmail = "SUPER@DENEME.COM",
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString()
            };

            //Sifre hashlemek icin: 
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();


            builder.HasData(user);

            user.PasswordHash = passwordHasher.HashPassword(user, "SuperUser_123");
        }
    }
}
