using ECommerceCapstone.Data;
using Microsoft.EntityFrameworkCore;

namespace LaZuittEcommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ECommerceContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDb")));

            builder.Services.AddControllersWithViews();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.IsEssential = true;
            });

            var app = builder.Build();

            app.UseSession();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "cart-update",
                    pattern: "Cart/UpdateCartItem",
                    defaults: new { controller = "Cart", action = "UpdateCartItem" }
                );

                using (var scope = app.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var context = services.GetRequiredService<ECommerceContext>();
                    SeedData.SeedDataBase(context);
                }
            });

            app.Run();
        }
    }
}
