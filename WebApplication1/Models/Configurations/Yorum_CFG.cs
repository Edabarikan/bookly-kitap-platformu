using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Configurations
{
    public class Yorum_CFG : IEntityTypeConfiguration<Yorum>
    {

        public void Configure(EntityTypeBuilder<Yorum> builder)
        {
            builder.Property(x => x.YorumMetni)
                   .HasMaxLength(300)
                   .HasColumnType("varchar")
                   .IsRequired();

            builder.Property(y => y.YorumTarihi)
           .HasColumnType("datetime2")   
           .HasDefaultValueSql("GETDATE()")  // Varsayılan olarak SQL Server'ın GETDATE() fonksiyonunu kullandık.Eğer YorumTarihi belirtilmeden veritabanına kayıt eklenirse, SQL Server otomatik olarak tarih atar.
           .IsRequired();



        }

    }
}
