using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string strConn = builder.Configuration.GetConnectionString("ConnStr"); //ConnectionString'i aliyor.
builder.Services.AddDbContext<KitapDBContext>(x => x.UseSqlServer(strConn)); //servis tanýmlamasý yapýyoruz, dbcontext'i sql serverda tanýmladýk.

builder.Services
    .AddIdentity<AppUser, AppRole>(x => x.SignIn.RequireConfirmedEmail = false)
     .AddEntityFrameworkStores<KitapDBContext>()
     .AddRoles<AppRole>(); //Bu kod, ASP.NET Core Identity'yi kullanarak kimlik dogrulama ve yetkilendirme sistemini yapilandiriyor.


builder.Services.AddTransient<KitapRepository>();  
builder.Services.AddTransient<KullaniciRepository>();  
builder.Services.AddTransient<KategoriRepository>();  
builder.Services.AddTransient<YayineviRepository>();  
builder.Services.AddTransient<YazarRepository>();  
builder.Services.AddTransient<YorumRepository>();  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication(); //middleware tanýmladýk.


app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
