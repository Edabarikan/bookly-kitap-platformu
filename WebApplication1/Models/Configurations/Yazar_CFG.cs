using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.Configurations
{
    public class Yazar_CFG : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {

            builder.Property(x => x.YazarAd)
                      .HasMaxLength(30)
                      .HasColumnType("varchar")
                      .IsRequired();

            builder.Property(x => x.YazarSoyad)
                      .HasMaxLength(30)
                      .HasColumnType("varchar")
                      .IsRequired();



            builder.HasData(
new Yazar { YazarID = 1, YazarAd = "Mustafa Kemal", YazarSoyad = "Atatürk" },
new Yazar { YazarID = 2, YazarAd = "Lev", YazarSoyad = "Nikolayeviç Tolstoy" },
new Yazar { YazarID = 3, YazarAd = "Fyodor", YazarSoyad = "Dostoyevski" },
new Yazar { YazarID = 4, YazarAd = "Mikhail", YazarSoyad = "Bulgakov" },
new Yazar { YazarID = 5, YazarAd = "Anton", YazarSoyad = "Çehov" },
new Yazar { YazarID = 6, YazarAd = "Selim", YazarSoyad = "İleri" },
new Yazar { YazarID = 7, YazarAd = "Orhan", YazarSoyad = "Pamuk" },
new Yazar { YazarID = 8, YazarAd = "George", YazarSoyad = "Orwell" },
new Yazar { YazarID = 9, YazarAd = "Haruki", YazarSoyad = "Murakami" },
new Yazar { YazarID = 10, YazarAd = "Jane", YazarSoyad = "Austen" },
new Yazar { YazarID = 11, YazarAd = "Ahmet", YazarSoyad = "Hamdi Tanpınar" },
new Yazar { YazarID = 12, YazarAd = "Mark", YazarSoyad = "Twain" },
new Yazar { YazarID = 13, YazarAd = "Ernest", YazarSoyad = "Hemingway" },
new Yazar { YazarID = 14, YazarAd = "F. Scott", YazarSoyad = "Fitzgerald" },
new Yazar { YazarID = 15, YazarAd = "Çetin", YazarSoyad = "Altan" },
new Yazar { YazarID = 16, YazarAd = "J.K.", YazarSoyad = "Rowling" },
new Yazar { YazarID = 17, YazarAd = "John", YazarSoyad = "Steinbeck" },
new Yazar { YazarID = 18, YazarAd = "Oscar", YazarSoyad = "Wilde" },
new Yazar { YazarID = 19, YazarAd = "Gabriel", YazarSoyad = "García Márquez" },
new Yazar { YazarID = 20, YazarAd = "Bülent", YazarSoyad = "Ecevit" },
new Yazar { YazarID = 21, YazarAd = "Ahmet", YazarSoyad = "Arpad" },
new Yazar { YazarID = 22, YazarAd = "J.R.R.", YazarSoyad = "Tolkien" },
new Yazar { YazarID = 23, YazarAd = "Margaret", YazarSoyad = "Atwood" },
new Yazar { YazarID = 24, YazarAd = "Neil", YazarSoyad = "Gaiman" },
new Yazar { YazarID = 25, YazarAd = "Nisan", YazarSoyad = "Tuncer" },
new Yazar { YazarID = 26, YazarAd = "Toni", YazarSoyad = "Morrison" },
new Yazar { YazarID = 27, YazarAd = "Ray", YazarSoyad = "Bradbury" },
new Yazar { YazarID = 28, YazarAd = "Tariq", YazarSoyad = "Ali" },
new Yazar { YazarID = 29, YazarAd = "Herman", YazarSoyad = "Melville" },
new Yazar { YazarID = 30, YazarAd = "Isaac", YazarSoyad = "Asimov" },
new Yazar { YazarID = 31, YazarAd = "Dante", YazarSoyad = "Alighieri" },
new Yazar { YazarID = 32, YazarAd = "Johann Wolfgang", YazarSoyad = "Goethe" },
new Yazar { YazarID = 33, YazarAd = "Albert", YazarSoyad = "Camus" },
new Yazar { YazarID = 34, YazarAd = "Süleyman", YazarSoyad = "Nazif" },
new Yazar { YazarID = 35, YazarAd = "Franz", YazarSoyad = "Kafka" },
new Yazar { YazarID = 36, YazarAd = "H.G.", YazarSoyad = "Wells" },
new Yazar { YazarID = 37, YazarAd = "Aldous", YazarSoyad = "Huxley" },
new Yazar { YazarID = 38, YazarAd = "William", YazarSoyad = "Golding" },
new Yazar { YazarID = 39, YazarAd = "T.S.", YazarSoyad = "Eliot" },
new Yazar { YazarID = 40, YazarAd = "Turgut", YazarSoyad = "Özakman" },
new Yazar { YazarID = 41, YazarAd = "Mehmet", YazarSoyad = "Akif Ersoy" },
new Yazar { YazarID = 42, YazarAd = "Philip", YazarSoyad = "K. Dick" },
new Yazar { YazarID = 43, YazarAd = "Jules", YazarSoyad = "Verne" },
new Yazar { YazarID = 44, YazarAd = "Arthur", YazarSoyad = "C. Clarke" },
new Yazar { YazarID = 45, YazarAd = "Douglas", YazarSoyad = "Adams" },
new Yazar { YazarID = 46, YazarAd = "Stephen", YazarSoyad = "King" },
new Yazar { YazarID = 47, YazarAd = "C.S.", YazarSoyad = "Lewis" },
new Yazar { YazarID = 48, YazarAd = "George", YazarSoyad = "Eliot" },
new Yazar { YazarID = 49, YazarAd = "John", YazarSoyad = "Milton" },
new Yazar { YazarID = 50, YazarAd = "Murat", YazarSoyad = "Mungan" },
new Yazar { YazarID = 51, YazarAd = "Ahmet", YazarSoyad = "Ümit" },
new Yazar { YazarID = 52, YazarAd = "Zadie", YazarSoyad = "Smith" },
new Yazar { YazarID = 53, YazarAd = "Tess", YazarSoyad = "Gerritsen" },
new Yazar { YazarID = 54, YazarAd = "Orhan", YazarSoyad = "Veli Kanık" },
new Yazar { YazarID = 55, YazarAd = "Mehmet", YazarSoyad = "Erdem" },
new Yazar { YazarID = 56, YazarAd = "Murat", YazarSoyad = "Bodur" },
new Yazar { YazarID = 57, YazarAd = "Tamer", YazarSoyad = "Çelik" },
new Yazar { YazarID = 58, YazarAd = "Nazlı", YazarSoyad = "Eray" },
new Yazar { YazarID = 59, YazarAd = "Cengiz", YazarSoyad = "Aytmatov" },
new Yazar { YazarID = 60, YazarAd = "Tom", YazarSoyad = "Hanks" },
new Yazar { YazarID = 61, YazarAd = "Alice", YazarSoyad = "Walker" },
new Yazar { YazarID = 62, YazarAd = "Mikhail", YazarSoyad = "Sholokhov" },
new Yazar { YazarID = 63, YazarAd = "Tezer", YazarSoyad = "Özlü" },
new Yazar { YazarID = 64, YazarAd = "Vladimir", YazarSoyad = "Nabokov" },
new Yazar { YazarID = 65, YazarAd = "Michael", YazarSoyad = "Ende" },
new Yazar { YazarID = 66, YazarAd = "Svetlana", YazarSoyad = "Aleksieviç" },
new Yazar { YazarID = 67, YazarAd = "Zülfü", YazarSoyad = "Livaneli" },
new Yazar { YazarID = 68, YazarAd = "Jack", YazarSoyad = "London" },
new Yazar { YazarID = 69, YazarAd = "Ahmet", YazarSoyad = "Hakan" },
new Yazar { YazarID = 70, YazarAd = "John", YazarSoyad = "Keats" },
new Yazar { YazarID = 71, YazarAd = "Sebastian", YazarSoyad = "Faulks" },
new Yazar { YazarID = 72, YazarAd = "Maksim", YazarSoyad = "Gorki" },
new Yazar { YazarID = 73, YazarAd = "Nikolai", YazarSoyad = "Gogol" },
new Yazar { YazarID = 74, YazarAd = "Rainer", YazarSoyad = "Maria Rilke" },
new Yazar { YazarID = 75, YazarAd = "Sibel", YazarSoyad = "Yılmaz" },
new Yazar { YazarID = 76, YazarAd = "Albert", YazarSoyad = "Einstein" },
new Yazar { YazarID = 77, YazarAd = "Edward", YazarSoyad = "Munch" },
new Yazar { YazarID = 78, YazarAd = "Marie", YazarSoyad = "Curie" },
new Yazar { YazarID = 79, YazarAd = "Ziya", YazarSoyad = "Gökalp" },
new Yazar { YazarID = 80, YazarAd = "Serdar", YazarSoyad = "Yılmaz" },
new Yazar { YazarID = 81, YazarAd = "Hannah", YazarSoyad = "Arendt" },
new Yazar { YazarID = 82, YazarAd = "Melih", YazarSoyad = "Cevdet Anday" },
new Yazar { YazarID = 83, YazarAd = "John", YazarSoyad = "Grisham" },
new Yazar { YazarID = 84, YazarAd = "Tarkan", YazarSoyad = "Çelik" },
new Yazar { YazarID = 85, YazarAd = "Yusuf", YazarSoyad = "Has Hacib" },
new Yazar { YazarID = 86, YazarAd = "Sarah", YazarSoyad = "J. Maas" },
new Yazar { YazarID = 87, YazarAd = "Hikmet", YazarSoyad = "Kıvılcımlı" },
new Yazar { YazarID = 88, YazarAd = "Ralph", YazarSoyad = "Ellison" },
new Yazar { YazarID = 89, YazarAd = "Alice", YazarSoyad = "Munro" },
new Yazar { YazarID = 90, YazarAd = "Melvin", YazarSoyad = "Buckland" },
new Yazar { YazarID = 91, YazarAd = "Michel", YazarSoyad = "Foucault" },
new Yazar { YazarID = 92, YazarAd = "Stefan", YazarSoyad = "Zweig" },
new Yazar { YazarID = 93, YazarAd = "Thomas", YazarSoyad = "Mann" },
new Yazar { YazarID = 94, YazarAd = "Maria", YazarSoyad = "Vargas Llosa" },
new Yazar { YazarID = 95, YazarAd = "Hassan", YazarSoyad = "Fattah" },
new Yazar { YazarID = 96, YazarAd = "Alice", YazarSoyad = "Sebold" },
new Yazar { YazarID = 97, YazarAd = "Ted", YazarSoyad = "Hughes" },
new Yazar { YazarID = 98, YazarAd = "Kurt", YazarSoyad = "Vonnegut" },
new Yazar { YazarID = 99, YazarAd = "Banu", YazarSoyad = "Bihter" },
new Yazar { YazarID = 100, YazarAd = "Yılmaz", YazarSoyad = "Özdemir" }
);
        }
    }
}
