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

// Controller: MVC yapısında controller, kullanıcılardan gelen HTTP isteklerini işleyen sınıftır.
// Action: Controller içinde, belirli bir HTTP isteğini işleyen fonksiyonlara verilen isimdir.
// Model: Uygulamanın verilerinin işlenip tutulduğu sınıfları temsil eder. Veri tabanı ile etkileşim kurar.
// View: Kullanıcıya gösterilecek olan HTML sayfalarıdır. Razor kullanılarak dinamik içerik sunulabilir.
// Razor: .cshtml dosyalarıyla kullanılır ve C# kodunu HTML içinde dinamik olarak kullanmamızı sağlar.
// RazorView: Dinamik olarak üretilen ve HTML çıktısı veren sayfalardır.
// wwwroot: Statik dosyaların tutulduğu klasördür. CSS, JS, resimler gibi dosyalar buraya yerleştirilir.
// builder.Build(): Uygulamayı yapılandırır ve çalıştırmak üzere hazır hale getirir.
// app.Run(): Uygulamayı başlatır ve gelen HTTP isteklerini dinlemeye başlar.
