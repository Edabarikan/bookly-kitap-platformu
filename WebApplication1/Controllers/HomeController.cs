using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KitapRepository _kitapRepository;
        private readonly KategoriRepository _kategoriRepository;
        private readonly YazarRepository _yazarRepository;
        private readonly YayineviRepository _yayineviRepository;
        public HomeController(ILogger<HomeController> logger, KitapRepository kitapRepository, KategoriRepository kategoriRepository, YazarRepository yazarRepository, YayineviRepository yayineviRepository)
        {
            _logger = logger;
            _kitapRepository = kitapRepository;
            _kategoriRepository = kategoriRepository;
            _yazarRepository = yazarRepository;
            _yayineviRepository = yayineviRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Blog()
        {
            var blogPosts = new List<BlogPost>
            {
                new BlogPost
                {
                    Date = "02-12-2025",
                    Title = "Kitapların Büyülü Dünyası",
                    Content = "Kitaplar, bizi farklı zamanlara ve mekanlara götüren büyülü kapılardır. Okurken hayal gücümüz gelişir, yeni bakış açıları kazanırız. Kitap okumak, zihnimizi açar, dünyaya farklı bir gözle bakmamıza yardımcı olur. Kitapların sunduğu bilgiler, hayal gücümüzü tetikler ve insanın kendisini daha iyi tanımasına olanak verir. Okuma alışkanlığı kazandıkça, hayatımıza katacağımız derinlik artar. Peki, sizin için en unutulmaz kitap hangisi? Kim bilir, belki de bir gün siz de o kitabın yazarı olacaksınız."
                },
                new BlogPost
                {
                    Date = "12-25-2024",
                    Title = "Kütüphane mi, Kitaplık mı?",
                    Content = "Kitapseverler için en büyük soru: Kitapları dijitalde mi yoksa basılı olarak mı saklamalı? Fiziksel kitaplar, kütüphanelerde ya da kitaplıklarda görsel bir estetik yaratır. Ancak dijital kitaplar, pratiklik açısından büyük avantajlar sağlar. Kitapların kokusu, dokusu, sayfaların çevrilmesi gibi fiziksel deneyimler kitapları özel kılar. Bununla birlikte, dijital kitaplar çok daha taşınabilir ve ulaşılabilir. Peki, hangi yöntemi tercih ediyorsunuz? Fiziksel kitapları mı yoksa dijital kitapları mı tercih ediyorsunuz? Bu konu her zaman tartışmalıdır."
                },
                new BlogPost
                {
                    Date = "01-18-2025",
                    Title = "Okuma Alışkanlığı Nasıl Kazanılır?",
                    Content = "Kitap okumaya zaman ayırmakta zorlanıyor musunuz? Günde sadece 10 dakika okuyarak bile büyük fark yaratabilirsiniz. Okuma alışkanlığı kazanmak, zihinsel gelişim için son derece önemlidir. Düzenli olarak kitap okuma, odaklanma ve dikkat süresini artırır. Okumaya başlamak için sevdiğiniz konuları seçin, böylece okuma süreci daha keyifli hale gelir. Ayrıca, okuma süresini kısa tutarak başlayabilirsiniz. Günde 15 dakika okumak bile bir fark yaratacaktır. İşte okuma alışkanlığı kazanmanın bazı ipuçları: Her gün belirli bir saatte kitap okuyun, okuma listeleri oluşturun ve okumayı bir rutin haline getirin."
                },
                new BlogPost
                {
                    Date = "01-30-2025",
                    Title = "Türüne Göre Kitap Seçimi",
                    Content = "Roman mı, kişisel gelişim mi, yoksa bilim kurgu mu? Kitap türü seçimi, okuma keyfini doğrudan etkiler. Doğru türde kitaplar seçmek, okuma alışkanlığını sürdürmek için önemlidir. Romanlar, duygusal derinlik ve karakter gelişimi sunar. Kişisel gelişim kitapları, hayatı daha verimli yaşama yöntemleri sunar. Bilim kurgu ise hayal gücünü genişleten ve teknolojiye dair yeni bakış açıları kazandıran kitaplar sunar. Hangi türü tercih ediyorsunuz? Ruh halinize en uygun kitap türü, okuma deneyiminizi zenginleştirecektir."
                }
            };

            return View(blogPosts);
        }

        public IActionResult AboutUs()
        {
            ViewBag.CompanyHistory = "Bookly, 2020 yılında kitap severlerin ihtiyaçlarını karşılamak için İstanbul, Türkiye'de kurulmuştur. Kitaplara olan derin tutkumuzla yola çıkarak, okurlarımıza yalnızca kitapları değil, aynı zamanda kaliteli içerik ve harika bir okuma deneyimi sunmayı hedefliyoruz. Kuruluşumuzdan bu yana, her yaştan ve her ilgi alanından okuyucumuza hitap eden geniş bir kitap koleksiyonu sunuyoruz. Bizim için önemli olan, okurlarımıza sadece kitap değil, aynı zamanda bilgiye erişim imkânı sağlamaktır. Kitap dünyasına olan sevgimizi her geçen gün daha fazla insana ulaştırmak için çalışıyoruz.";

            ViewBag.Address = "Bookly, İstanbul, Türkiye \n\n Merkez Ofis: Caddebostan Mah. Kitap Sok. No:10, İstanbul\n\n Ofis İletişim: +90 123 456 7890";

            ViewBag.Contact = "E-posta: info@bookly.com\nTelefon: +90 123 456 7890\n\nSosyal Medya: @booklybookstore (Instagram/Twitter/Facebook)";

            ViewBag.Advertisement = "Bookly, her yaştan ve her türden kitap okurunun ihtiyaçlarına hitap eden zengin bir koleksiyona sahip bir platformdur. Okuma alışkanlıklarınızı geliştirmek ve kitap dünyasında derinlemesine keşfe çıkmak isteyen herkes için mükemmel bir seçenektir. Geniş koleksiyonumuzda romanlardan kişisel gelişim kitaplarına, edebiyatın her dalından eserleri bulabilir, aradığınız kitaplara kolayca ulaşabilirsiniz. Ayrıca, kullanıcı dostu platformumuz sayesinde, kitapseverler rahatça kitaplarını keşfeder, favori yazarlarını takip eder ve en güncel kitapları alabilirler. Bizimle okumaya başlamak, hem eğitici hem de eğlenceli bir deneyimdir.";

            return View();
        }


      //Header'daki Vitrin butonunun tum modeller icin listeleme yapmasi isteniyor. CRUD yetkilendirmeleri sadece Admin'de olup, burada sadece listeleme yapilacaktir. Ilgili repositoryler HomeController'da constructor injection ile cagirilmistir.
        public async Task<IActionResult> Kitaplar()
        {
            var kitaplar = await _kitapRepository.Listele();
            if (kitaplar == null)
            {
                return View(new List<Kitap_VM>());
            }
            var kitapVmList = kitaplar.Select(kitap => new Kitap_VM
            {
                KitapID = kitap.KitapID,
                KitapAdi = kitap.KitapAdi,
                Yazar = kitap.Yazar.YazarAdSoyad,
                Fiyat = kitap.Fiyat
            }).ToList();

            return View(kitapVmList);
        }


        public async Task<IActionResult> Kategoriler()
        {
            var kategoriler = await _kategoriRepository.Listele();

            var kategoriVmList = kategoriler.Select(kategori => new Kategori_VM
            {
                KategoriID = kategori.KategoriID,
                KategoriAdi = kategori.KategoriAdi
            }).ToList();

            return View(kategoriVmList);
        }



        public async Task<IActionResult> Yazarlar()
        {
            var yazarlar = await _yazarRepository.Listele();

            var yazarVmList = yazarlar.Select(yazar => new Yazar_VM
            {
                YazarID = yazar.YazarID,
                YazarAdSoyad = yazar.YazarAdSoyad
            }).ToList();

            return View(yazarVmList);
        }


        public async Task<IActionResult> Yayinevleri()
        {
            var yayinevleri = await _yayineviRepository.Listele();

            var yayineviVmList = yayinevleri.Select(yayinevi => new Yayinevi_VM
            {
                YayineviID = yayinevi.YayineviID,
                YayineviAdi = yayinevi.YayineviAdi
            }).ToList();

            return View(yayineviVmList);
        }
    }
}
