using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.Configurations
{
    public class KitapYayinevi_CFG : IEntityTypeConfiguration<KitapYayinevi>
    {
        public void Configure(EntityTypeBuilder<KitapYayinevi> builder)
        {
            builder.HasKey(ky => ky.KitapYayineviID); // Primary key

            // Kitap iliskisi
            builder.HasOne(ky => ky.Kitap)
                .WithMany(k => k.KitaplarYayinevleri)
                .HasForeignKey(ky => ky.KitapID)
                .OnDelete(DeleteBehavior.NoAction); // Silme islemi etkisiz

            // Yayınevi ilişkisi
            builder.HasOne(ky => ky.Yayinevi)
                .WithMany(y => y.KitaplarYayinevleri)
                .HasForeignKey(ky => ky.YayineviID)
                .OnDelete(DeleteBehavior.NoAction); // Silme islemi etkisiz

            //Kitap veya Yayinevi silindiginde, iliskili KitapYayinevi kayitlari otomatik olarak silinmiyor.Bir Kitap ya da Yayinevi silinecekse, manuel olarak iliskili kayitlari da silmek gerekir.
        }
    }
}
