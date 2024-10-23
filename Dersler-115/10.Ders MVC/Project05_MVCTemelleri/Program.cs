namespace Project05_MVCTemelleri;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);//Bir web application oluşturucu yaratılıyor.

        // Bu satırla bu uygulamanın bir MVC uygulaması olacağı bildiriliyor.
        builder.Services.AddControllersWithViews();

        var app = builder.Build(); //Bir web application(MVC) oluşturuluyor.

        // Bu aşamadan run yapılana kadar olan kısımda gelen istekler yapılandırlıyor.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection(); //http üzerinden gelen istekleri https' e yönlendirir
        app.UseStaticFiles(); // wwwroot klasörünün kullanılabilir olmasını sağlar.

        app.UseRouting();// Gelen isteklerin hangi controller'a gitmesi gerektiğini belirler.

        app.UseAuthorization();// Yetkilendirme özelliklerini aktif kılar.

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"); //buradaki patern aslında bir controller yazmassak default olarak home olması aynu zamanda bir action yazmadığımızda default olarak Index olması aşağıdaki 3 link te aynı.:
            //https://locakhost:5100/Home/Index
            //https://locakhost:5100/Home
            //https://locakhost:5100

            //https://locakhost:5100
            //https://locakhost:5100
            //https://locakhost:5100
            //https://locakhost:5100

        app.Run(); //oluşturulan web application çalıştırılıyor...
    }
}
