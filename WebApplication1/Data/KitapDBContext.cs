using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class KitapDBContext: IdentityDbContext<AppUser, AppRole, int>
    {
        public KitapDBContext() //Migration, default ctor ister.
        {

        }

        public KitapDBContext(DbContextOptions options):base(options)  //Container nesne (context sinifi) parametrik ctor ister.
        {

        }

        public DbSet<Kitap> Kitaplar { get; set; }  
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kategori> Kategoriler{ get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<KitapYayinevi> KitaplarYayinevleri { get; set; }   
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { UserId = 1, RoleId = 1 }); //SuperUser'i admin olarak vermis olduk.

            modelBuilder.Entity<Kitap>()
        .HasOne(k => k.User)  // Kitap -> AppUser iliskisi
        .WithMany(u => u.Kitaplar)  // AppUser -> Kitap iliskisi
        .HasForeignKey(k => k.AppUserID)  // Kitap'taki AppUserID'yi foreign key olarak veriyoruz.
        .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
