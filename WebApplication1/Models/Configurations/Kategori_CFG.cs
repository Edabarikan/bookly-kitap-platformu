using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.Configurations
{
    public class Kategori_CFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.Property(x => x.KategoriAdi)
                     .HasMaxLength(30)
                     .HasColumnType("varchar")
                     .IsRequired();

            builder.HasData(
new Kategori { KategoriID = 1, KategoriAdi = "Roman" },
new Kategori { KategoriID = 2, KategoriAdi = "Şiir" },
new Kategori { KategoriID = 3, KategoriAdi = "Deneme" },
new Kategori { KategoriID = 4, KategoriAdi = "Hikaye" },
new Kategori { KategoriID = 5, KategoriAdi = "Biyografi" },
new Kategori { KategoriID = 6, KategoriAdi = "Tarih" },
new Kategori { KategoriID = 7, KategoriAdi = "Felsefe" },
new Kategori { KategoriID = 8, KategoriAdi = "Bilimkurgu" },
new Kategori { KategoriID = 9, KategoriAdi = "Klasik" },
new Kategori { KategoriID = 10, KategoriAdi = "Psikoloji" },
new Kategori { KategoriID = 11, KategoriAdi = "Çocuk Kitapları" },
new Kategori { KategoriID = 12, KategoriAdi = "Kişisel Gelişim" },
new Kategori { KategoriID = 13, KategoriAdi = "Politika" },
new Kategori { KategoriID = 14, KategoriAdi = "Edebiyat Kuramı" },
new Kategori { KategoriID = 15, KategoriAdi = "Sosyoloji" },
new Kategori { KategoriID = 16, KategoriAdi = "Mizah" },
new Kategori { KategoriID = 17, KategoriAdi = "Savaş" },
new Kategori { KategoriID = 18, KategoriAdi = "Fantastik" },
new Kategori { KategoriID = 19, KategoriAdi = "Macera" },
new Kategori { KategoriID = 20, KategoriAdi = "Aşk" },
new Kategori { KategoriID = 21, KategoriAdi = "Edebiyat Tarihi" },
new Kategori { KategoriID = 22, KategoriAdi = "Gerilim" },
new Kategori { KategoriID = 23, KategoriAdi = "Sanat" },
new Kategori { KategoriID = 24, KategoriAdi = "Eğitim" },
new Kategori { KategoriID = 25, KategoriAdi = "Korku" }
           );
        }
    }
}
