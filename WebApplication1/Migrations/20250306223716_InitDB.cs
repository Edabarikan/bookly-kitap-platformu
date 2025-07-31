using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevleri",
                columns: table => new
                {
                    YayineviID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayineviAdi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayinevleri", x => x.YayineviID);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    YazarSoyad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false),
                    YayineviID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false),
                    KapakResmi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    AppUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapID);
                    table.ForeignKey(
                        name: "FK_Kitaplar_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Yazarlar_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitaplarYayinevleri",
                columns: table => new
                {
                    KitapYayineviID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapID = table.Column<int>(type: "int", nullable: false),
                    YayineviID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitaplarYayinevleri", x => x.KitapYayineviID);
                    table.ForeignKey(
                        name: "FK_KitaplarYayinevleri_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapID");
                    table.ForeignKey(
                        name: "FK_KitaplarYayinevleri_Yayinevleri_YayineviID",
                        column: x => x.YayineviID,
                        principalTable: "Yayinevleri",
                        principalColumn: "YayineviID");
                });

            migrationBuilder.CreateTable(
                name: "Yorumlar",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumMetni = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    KitapID = table.Column<int>(type: "int", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    YorumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlar", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorumlar_AspNetUsers_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Yorumlar_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "c2212fae-c136-472f-afc1-a060f6573084", "Admin", "ADMIN" },
                    { 2, "6309a9ee-3754-471c-8e25-06d41fd0bf48", "Uye", "UYE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "Adres", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "Super", "Turkiye", "f7ff238f-6ed4-45bf-89d7-9e731c95caf2", "super@deneme.com", true, "Super User", false, null, "SUPER@DENEME.COM", "SUPERUSER", "AQAAAAIAAYagAAAAEE1jFcQaH4pKsHvqIf4JJhYFRNuxP3VWX4T4TcvMh2NyFcXoeWS3SzzgA+hH2wlqJg==", null, false, "e92d0441-08e0-446e-a6c2-2436bf8b6994", "User", false, "superUser" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Roman" },
                    { 2, "Şiir" },
                    { 3, "Deneme" },
                    { 4, "Hikaye" },
                    { 5, "Biyografi" },
                    { 6, "Tarih" },
                    { 7, "Felsefe" },
                    { 8, "Bilimkurgu" },
                    { 9, "Klasik" },
                    { 10, "Psikoloji" },
                    { 11, "Çocuk Kitapları" },
                    { 12, "Kişisel Gelişim" },
                    { 13, "Politika" },
                    { 14, "Edebiyat Kuramı" },
                    { 15, "Sosyoloji" },
                    { 16, "Mizah" },
                    { 17, "Savaş" },
                    { 18, "Fantastik" },
                    { 19, "Macera" },
                    { 20, "Aşk" },
                    { 21, "Edebiyat Tarihi" },
                    { 22, "Gerilim" },
                    { 23, "Sanat" },
                    { 24, "Eğitim" },
                    { 25, "Korku" },
                    { 26, "Siyasi Edebiyat" },
                    { 27, "Mistik" },
                    { 28, "Ekonomi" },
                    { 29, "Biyoloji" },
                    { 30, "Mühendislik" },
                    { 31, "Tıp" },
                    { 32, "Felsefi Roman" },
                    { 33, "Kültürel Çalışmalar" },
                    { 34, "Gezi" },
                    { 35, "Edebiyat Eleştirisi" },
                    { 36, "Arkeoloji" },
                    { 37, "Doğa" },
                    { 38, "Efsane" },
                    { 39, "Zaman Yolculuğu" },
                    { 40, "Kişisel Anlatı" },
                    { 41, "Bilinçli Farkındalık" },
                    { 42, "Felsefi Deneme" },
                    { 43, "Din" },
                    { 44, "Çevre" },
                    { 45, "Sosyal Medya" },
                    { 46, "Müzik" },
                    { 47, "Edebiyat Teorisi" },
                    { 48, "Karmaşık Sistemler" },
                    { 49, "Savaş Hikayesi" },
                    { 50, "Politik Psikoloji" }
                });

            migrationBuilder.InsertData(
                table: "Yayinevleri",
                columns: new[] { "YayineviID", "YayineviAdi" },
                values: new object[,]
                {
                    { 1, "Can Yayınları" },
                    { 2, "Yapı Kredi Yayınları" },
                    { 3, "İş Bankası Kültür Yayınları" },
                    { 4, "Everest Yayınları" },
                    { 5, "Doğan Kitap" },
                    { 6, "Remzi Kitabevi" },
                    { 7, "Timaş Yayınları" },
                    { 8, "Altın Kitaplar" },
                    { 9, "Ketebe Yayınları" },
                    { 10, "Epsilon Yayınları" }
                });

            migrationBuilder.InsertData(
                table: "Yazarlar",
                columns: new[] { "YazarID", "YazarAd", "YazarSoyad" },
                values: new object[,]
                {
                    { 1, "Mustafa Kemal", "Atatürk" },
                    { 2, "Lev", "Nikolayeviç Tolstoy" },
                    { 3, "Fyodor", "Dostoyevski" },
                    { 4, "Mikhail", "Bulgakov" },
                    { 5, "Anton", "Çehov" },
                    { 6, "Selim", "İleri" },
                    { 7, "Orhan", "Pamuk" },
                    { 8, "George", "Orwell" },
                    { 9, "Haruki", "Murakami" },
                    { 10, "Jane", "Austen" },
                    { 11, "Ahmet", "Hamdi Tanpınar" },
                    { 12, "Mark", "Twain" },
                    { 13, "Ernest", "Hemingway" },
                    { 14, "F. Scott", "Fitzgerald" },
                    { 15, "Çetin", "Altan" },
                    { 16, "J.K.", "Rowling" },
                    { 17, "John", "Steinbeck" },
                    { 18, "Oscar", "Wilde" },
                    { 19, "Gabriel", "García Márquez" },
                    { 20, "Bülent", "Ecevit" },
                    { 21, "Ahmet", "Arpad" },
                    { 22, "J.R.R.", "Tolkien" },
                    { 23, "Margaret", "Atwood" },
                    { 24, "Neil", "Gaiman" },
                    { 25, "Nisan", "Tuncer" },
                    { 26, "Toni", "Morrison" },
                    { 27, "Ray", "Bradbury" },
                    { 28, "Tariq", "Ali" },
                    { 29, "Herman", "Melville" },
                    { 30, "Isaac", "Asimov" },
                    { 31, "Dante", "Alighieri" },
                    { 32, "Johann Wolfgang", "Goethe" },
                    { 33, "Albert", "Camus" },
                    { 34, "Süleyman", "Nazif" },
                    { 35, "Franz", "Kafka" },
                    { 36, "H.G.", "Wells" },
                    { 37, "Aldous", "Huxley" },
                    { 38, "William", "Golding" },
                    { 39, "T.S.", "Eliot" },
                    { 40, "Turgut", "Özakman" },
                    { 41, "Mehmet", "Akif Ersoy" },
                    { 42, "Philip", "K. Dick" },
                    { 43, "Jules", "Verne" },
                    { 44, "Arthur", "C. Clarke" },
                    { 45, "Douglas", "Adams" },
                    { 46, "Stephen", "King" },
                    { 47, "C.S.", "Lewis" },
                    { 48, "George", "Eliot" },
                    { 49, "John", "Milton" },
                    { 50, "Murat", "Mungan" },
                    { 51, "Ahmet", "Ümit" },
                    { 52, "Zadie", "Smith" },
                    { 53, "Tess", "Gerritsen" },
                    { 54, "Orhan", "Veli Kanık" },
                    { 55, "Mehmet", "Erdem" },
                    { 56, "Murat", "Bodur" },
                    { 57, "Tamer", "Çelik" },
                    { 58, "Nazlı", "Eray" },
                    { 59, "Cengiz", "Aytmatov" },
                    { 60, "Tom", "Hanks" },
                    { 61, "Alice", "Walker" },
                    { 62, "Mikhail", "Sholokhov" },
                    { 63, "Tezer", "Özlü" },
                    { 64, "Vladimir", "Nabokov" },
                    { 65, "Michael", "Ende" },
                    { 66, "Svetlana", "Aleksieviç" },
                    { 67, "Zülfü", "Livaneli" },
                    { 68, "Jack", "London" },
                    { 69, "Ahmet", "Hakan" },
                    { 70, "John", "Keats" },
                    { 71, "Sebastian", "Faulks" },
                    { 72, "Maksim", "Gorki" },
                    { 73, "Nikolai", "Gogol" },
                    { 74, "Rainer", "Maria Rilke" },
                    { 75, "Sibel", "Yılmaz" },
                    { 76, "Albert", "Einstein" },
                    { 77, "Edward", "Munch" },
                    { 78, "Marie", "Curie" },
                    { 79, "Ziya", "Gökalp" },
                    { 80, "Serdar", "Yılmaz" },
                    { 81, "Hannah", "Arendt" },
                    { 82, "Melih", "Cevdet Anday" },
                    { 83, "John", "Grisham" },
                    { 84, "Tarkan", "Çelik" },
                    { 85, "Yusuf", "Has Hacib" },
                    { 86, "Sarah", "J. Maas" },
                    { 87, "Hikmet", "Kıvılcımlı" },
                    { 88, "Ralph", "Ellison" },
                    { 89, "Alice", "Munro" },
                    { 90, "Melvin", "Buckland" },
                    { 91, "Michel", "Foucault" },
                    { 92, "Stefan", "Zweig" },
                    { 93, "Thomas", "Mann" },
                    { 94, "Maria", "Vargas Llosa" },
                    { 95, "Hassan", "Fattah" },
                    { 96, "Alice", "Sebold" },
                    { 97, "Ted", "Hughes" },
                    { 98, "Kurt", "Vonnegut" },
                    { 99, "Banu", "Bihter" },
                    { 100, "Yılmaz", "Özdemir" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Kitaplar",
                columns: new[] { "KitapID", "Aciklama", "AppUserID", "Fiyat", "KapakResmi", "KategoriID", "KitapAdi", "YayineviID", "YazarID" },
                values: new object[,]
                {
                    { 1, "Yaşar Kemal’in eşsiz anlatımıyla köy hayatını ve eşkıya İnce Memed’in destansı hikayesini anlatır.", 1, 120.5m, "ince-memed.jpg", 1, "İnce Memed", 1, 3 },
                    { 2, "Tolstoy’un başyapıtı, Napolyon savaşları sırasında Rus aristokrasisinin hayatını ve içsel savaşlarını anlatır.", 1, 150.75m, "savas-ve-barish.jpg", 1, "Savaş ve Barış", 2, 1 },
                    { 3, "Dostoyevski’nin en bilinen romanlarından biri, bir cinayeti ve suçlulukla yüzleşen bir adamın psikolojik derinliğini keşfeder.", 1, 95m, "suc-ve-ceza.jpg", 1, "Suç ve Ceza", 3, 2 },
                    { 4, "Saint-Exupéry’nin çocuklar ve yetişkinler için derin anlamlar içeren masalı, evrenin sadeliği ve insanlık üzerine düşündürür.", 1, 60.5m, "kucuk-prens.jpg", 1, "Küçük Prens", 4, 4 },
                    { 5, "Stefan Zweig'in, insanın ruhsal çöküşünü detaylı bir şekilde ele aldığı etkileyici bir roman.", 1, 85m, "bir-cokusun-hikayesi.jpg", 1, "Bir Çöküşün Hikayesi", 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_AppUserID",
                table: "Kitaplar",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriID",
                table: "Kitaplar",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YazarID",
                table: "Kitaplar",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_KitaplarYayinevleri_KitapID",
                table: "KitaplarYayinevleri",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_KitaplarYayinevleri_YayineviID",
                table: "KitaplarYayinevleri",
                column: "YayineviID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_KitapID",
                table: "Yorumlar",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_KullaniciID",
                table: "Yorumlar",
                column: "KullaniciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "KitaplarYayinevleri");

            migrationBuilder.DropTable(
                name: "Yorumlar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Yayinevleri");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Yazarlar");
        }
    }
}
