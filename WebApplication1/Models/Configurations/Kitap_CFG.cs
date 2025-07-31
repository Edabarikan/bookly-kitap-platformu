using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.Configurations
{
    public class Kitap_CFG : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {

           builder.Property(x=>x.KitapAdi)
                   .HasMaxLength(60)
                   .HasColumnType("varchar")
                   .IsRequired();

            builder.Property(x => x.Fiyat)
                      .HasColumnType("money")
                      .IsRequired();

            

            builder.Property(x => x.Aciklama)
                      .HasMaxLength(800)
                      .HasColumnType("varchar")
                      .IsRequired();

            builder.Property(x => x.KapakResmi)
                      .HasMaxLength(100)
                      .HasColumnType("varchar");

            builder.Property(x => x.EklenmeTarihi)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()");


                builder.HasData(
new Kitap { KitapID = 1, KitapAdi = "İnce Memed", Fiyat = 120.50, YazarID = 3, KategoriID = 1, Aciklama = "Yaşar Kemal’in eşsiz anlatımıyla köy hayatını ve eşkıya İnce Memed’in destansı hikayesini anlatır.", KapakResmi = "ince-memed.jpg", YayineviID = 1, AppUserID = 1 },
new Kitap { KitapID = 2, KitapAdi = "Savaş ve Barış", Fiyat = 150.75, YazarID = 1, KategoriID = 1, Aciklama = "Tolstoy’un başyapıtı, Napolyon savaşları sırasında Rus aristokrasisinin hayatını ve içsel savaşlarını anlatır.", KapakResmi = "savas-ve-barish.jpg", YayineviID = 2, AppUserID = 1 },
new Kitap { KitapID = 3, KitapAdi = "Suç ve Ceza", Fiyat = 95.00, YazarID = 2, KategoriID = 1, Aciklama = "Dostoyevski’nin en bilinen romanlarından biri, bir cinayeti ve suçlulukla yüzleşen bir adamın psikolojik derinliğini keşfeder.", KapakResmi = "suc-ve-ceza.jpg", YayineviID = 3, AppUserID = 1 },
new Kitap { KitapID = 4, KitapAdi = "Küçük Prens", Fiyat = 60.50, YazarID = 4, KategoriID = 1, Aciklama = "Saint-Exupéry’nin çocuklar ve yetişkinler için derin anlamlar içeren masalı, evrenin sadeliği ve insanlık üzerine düşündürür.", KapakResmi = "kucuk-prens.jpg", YayineviID = 4, AppUserID = 1 },
new Kitap { KitapID = 5, KitapAdi = "Bir Çöküşün Hikayesi", Fiyat = 85.00, YazarID = 5, KategoriID = 1, Aciklama = "Stefan Zweig'in, insanın ruhsal çöküşünü detaylı bir şekilde ele aldığı etkileyici bir roman.", KapakResmi = "bir-cokusun-hikayesi.jpg", YayineviID = 5, AppUserID = 1 }

                );

        }
    }
}
