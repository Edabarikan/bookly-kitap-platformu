using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApplication1.Repositories
{
    public class KitapRepository : BaseRepository<Kitap>
    {

        public KitapRepository(KitapDBContext context) : base(context) { }

        public async Task<List<Kitap>> TumKitaplar()
        {
            return await context.Kitaplar
                .Include(x => x.Yazar) // Bire çok ilişki (1 Kitap -> 1 Yazar)
                .Include(x => x.Kategori) // Bire çok ilişki (1 Kitap -> 1 Kategori)
                .Include(x => x.KitaplarYayinevleri) // Çoka çok ilişki (1 Kitap -> M Yayinevi)
                    .ThenInclude(x => x.Yayinevi) // KitapYayinevi tablosu üzerinden Yayinevi bilgilerini çekiyoruz
                .ToListAsync();
        }

        public async Task<Kitap> IDyeGoreKitaplar(int id)
        {
            return await context.Kitaplar
                .Include(k => k.Yazar)       // Yazarı ekledik
                .Include(k => k.Kategori)    // Kategoriyi ekledik
                .Include(k => k.KitaplarYayinevleri) // Çoka-çok yayınevlerini ekledik
                    .ThenInclude(ky => ky.Yayinevi)
                .Include(k => k.Yorumlar)    // Bire-çok ilişki olan yorumları ekledik
                .FirstOrDefaultAsync(k => k.KitapID == id);
        }


        //Kitap-Yayınevi ilişkisini ekleme
        public async Task KitapYayineviEkleme(int kitapID, int yayineviID)
        {
            var kitapYayinevi = new KitapYayinevi { KitapID = kitapID, YayineviID = yayineviID };
            context.KitaplarYayinevleri.Add(kitapYayinevi);
            await context.SaveChangesAsync();
        }

        //Kitap-Yayınevi ilişkisini güncelleme
        public async Task KitapYayineviGuncelleme(int kitapID, int[] yayineviID)
        {
            var mevcutIliskiler = context.KitaplarYayinevleri.Where(x => x.KitapID == kitapID);
            context.KitaplarYayinevleri.RemoveRange(mevcutIliskiler);

            foreach (var id in yayineviID)
            {
                context.KitaplarYayinevleri.Add(new KitapYayinevi { KitapID = kitapID, YayineviID = id });
            }

            await context.SaveChangesAsync();
        }
    }
}
