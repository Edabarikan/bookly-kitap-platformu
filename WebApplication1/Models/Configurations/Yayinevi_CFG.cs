using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.Configurations
{
    public class Yayinevi_CFG : IEntityTypeConfiguration<Yayinevi>
    {
        public void Configure(EntityTypeBuilder<Yayinevi> builder)
        {

            builder.Property(x => x.YayineviAdi)
                      .HasMaxLength(30)
                      .HasColumnType("varchar")
                      .IsRequired();

            builder.HasData(
                new Yayinevi { YayineviID = 1, YayineviAdi = "Can Yayınları" },
                new Yayinevi { YayineviID = 2, YayineviAdi = "Yapı Kredi Yayınları" },
                new Yayinevi { YayineviID = 3, YayineviAdi = "İş Bankası Kültür Yayınları" },
                new Yayinevi { YayineviID = 4, YayineviAdi = "Everest Yayınları" },
                new Yayinevi { YayineviID = 5, YayineviAdi = "Doğan Kitap" },
                new Yayinevi { YayineviID = 6, YayineviAdi = "Remzi Kitabevi" },
                new Yayinevi { YayineviID = 7, YayineviAdi = "Timaş Yayınları" },
                new Yayinevi { YayineviID = 8, YayineviAdi = "Altın Kitaplar" },
                new Yayinevi { YayineviID = 9, YayineviAdi = "Ketebe Yayınları" },
                new Yayinevi { YayineviID = 10, YayineviAdi = "Epsilon Yayınları" }
                       );
        }
    }
}
