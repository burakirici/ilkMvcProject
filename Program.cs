var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//1. Controller (Denetleyici)
//Ne Ýþe Yarar?: Kullanýcýnýn tarayýcýdan yaptýðý istekleri karþýlayan ve yöneten sýnýftýr. HTTP isteklerini alýr, ilgili iþlemleri baþlatýr ve hangi verilerin gösterileceðini belirler.
//Amaç?: Ýþ mantýðý ve kullanýcýdan gelen istekler ile sunulacak veri arasýnda köprü kurar. Bu istekleri ilgili Action metodlarýna yönlendirir.

//2. Action (Eylem)
//Ne Ýþe Yarar?: Bir denetleyici içindeki her bir metod bir Action olarak adlandýrýlýr. Kullanýcý bir URL'e istek yaptýðýnda bu metotlar çalýþýr.
//Amaç?: Ýlgili kullanýcý isteðini iþleyip gerekli veriyi hazýrlamak ve uygun bir yanýt döndürmek.

//3. Model
//Ne Ýþe Yarar?: Uygulamanýn veritabaný veya veri yapýsýyla ilgili kýsýmlarýný temsil eder. Veriler genellikle bu model sýnýflarýnda tanýmlanýr ve doðrulamalar yapýlabilir.
//Amaç?: Verilerin yapýsýný tanýmlamak ve iþ kurallarýna göre iþlemleri gerçekleþtirmek.

//4. View (Görünüm)
//Ne Ýþe Yarar?: Kullanýcýya gösterilecek HTML içeriðinin oluþturulduðu yerdir. Controller tarafýndan saðlanan model verisini kullanýcýya görsel olarak sunar.
//Amaç?: Veriyi uygun bir biçimde kullanýcý arayüzüne taþýmak.

//5. Razor
//Ne Ýþe Yarar?: C# kodlarýný HTML ile birlikte yazmayý saðlayan bir þablon dilidir. Dinamik web sayfalarý oluþturmak için kullanýlýr.
//Amaç?: Sunucu taraflý kod ile HTML içeriði birleþtirip dinamik içerik oluþturmak.

//6. Razor View
//Ne Ýþe Yarar?: Razor þablonlarýnýn(cshtml dosyalarýnýn) bulunduðu yerdir. View'lar genellikle Razor dosyalarýyla temsil edilir.
//Amaç?: HTML ve C# kodlarýnýn bir arada kullanýldýðý þablon dosyalarý.

//7. wwwroot
//Ne Ýþe Yarar?: Uygulamanýn tüm statik dosyalarýnýn (CSS, JavaScript, resim dosyalarý vb.) bulunduðu dizindir. Bu klasör dýþýndaki dosyalar doðrudan istemciler tarafýndan eriþilemez.
//Amaç?: Statik kaynak dosyalarýný tutmak.

//8.builder.Build()
//Ne Ýþe Yarar?: ASP.NET Core uygulamasýnýn yapýlandýrma aþamasýnýn tamamlandýðýný belirtir ve uygulamayý baþlatmaya hazýr hale getirir.
//Amaç?: Uygulamanýn yapýlandýrýlmasýný bitirir ve gerekli bileþenlerin (middleware) sýralandýðý bir uygulama nesnesi (IApplicationBuilder) döndürür.

//9. app.Run()
//Ne Ýþe Yarar?: Uygulamayý baþlatan ve gelen HTTP isteklerini karþýlayan bir middleware'i çalýþtýrýr. Bu, genellikle uygulamanýn son middleware'idir.
//Amaç?: Uygulamayý çalýþtýrmak ve istemciden gelen HTTP isteklerini iþlemek üzere hazýrlamak.