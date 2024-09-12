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
//Ne ��e Yarar?: Kullan�c�n�n taray�c�dan yapt��� istekleri kar��layan ve y�neten s�n�ft�r. HTTP isteklerini al�r, ilgili i�lemleri ba�lat�r ve hangi verilerin g�sterilece�ini belirler.
//Ama�?: �� mant��� ve kullan�c�dan gelen istekler ile sunulacak veri aras�nda k�pr� kurar. Bu istekleri ilgili Action metodlar�na y�nlendirir.

//2. Action (Eylem)
//Ne ��e Yarar?: Bir denetleyici i�indeki her bir metod bir Action olarak adland�r�l�r. Kullan�c� bir URL'e istek yapt���nda bu metotlar �al���r.
//Ama�?: �lgili kullan�c� iste�ini i�leyip gerekli veriyi haz�rlamak ve uygun bir yan�t d�nd�rmek.

//3. Model
//Ne ��e Yarar?: Uygulaman�n veritaban� veya veri yap�s�yla ilgili k�s�mlar�n� temsil eder. Veriler genellikle bu model s�n�flar�nda tan�mlan�r ve do�rulamalar yap�labilir.
//Ama�?: Verilerin yap�s�n� tan�mlamak ve i� kurallar�na g�re i�lemleri ger�ekle�tirmek.

//4. View (G�r�n�m)
//Ne ��e Yarar?: Kullan�c�ya g�sterilecek HTML i�eri�inin olu�turuldu�u yerdir. Controller taraf�ndan sa�lanan model verisini kullan�c�ya g�rsel olarak sunar.
//Ama�?: Veriyi uygun bir bi�imde kullan�c� aray�z�ne ta��mak.

//5. Razor
//Ne ��e Yarar?: C# kodlar�n� HTML ile birlikte yazmay� sa�layan bir �ablon dilidir. Dinamik web sayfalar� olu�turmak i�in kullan�l�r.
//Ama�?: Sunucu tarafl� kod ile HTML i�eri�i birle�tirip dinamik i�erik olu�turmak.

//6. Razor View
//Ne ��e Yarar?: Razor �ablonlar�n�n(cshtml dosyalar�n�n) bulundu�u yerdir. View'lar genellikle Razor dosyalar�yla temsil edilir.
//Ama�?: HTML ve C# kodlar�n�n bir arada kullan�ld��� �ablon dosyalar�.

//7. wwwroot
//Ne ��e Yarar?: Uygulaman�n t�m statik dosyalar�n�n (CSS, JavaScript, resim dosyalar� vb.) bulundu�u dizindir. Bu klas�r d���ndaki dosyalar do�rudan istemciler taraf�ndan eri�ilemez.
//Ama�?: Statik kaynak dosyalar�n� tutmak.

//8.builder.Build()
//Ne ��e Yarar?: ASP.NET Core uygulamas�n�n yap�land�rma a�amas�n�n tamamland���n� belirtir ve uygulamay� ba�latmaya haz�r hale getirir.
//Ama�?: Uygulaman�n yap�land�r�lmas�n� bitirir ve gerekli bile�enlerin (middleware) s�raland��� bir uygulama nesnesi (IApplicationBuilder) d�nd�r�r.

//9. app.Run()
//Ne ��e Yarar?: Uygulamay� ba�latan ve gelen HTTP isteklerini kar��layan bir middleware'i �al��t�r�r. Bu, genellikle uygulaman�n son middleware'idir.
//Ama�?: Uygulamay� �al��t�rmak ve istemciden gelen HTTP isteklerini i�lemek �zere haz�rlamak.