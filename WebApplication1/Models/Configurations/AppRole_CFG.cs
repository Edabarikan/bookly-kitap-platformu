using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.Configurations
{
    public class AppRole_CFG : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            //Varsayilan Admin ve Uye eklendi.
            builder.HasData(
                new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new AppRole { Id = 2, Name = "Uye", NormalizedName = "UYE", ConcurrencyStamp = Guid.NewGuid().ToString() });
        }
    }
}
