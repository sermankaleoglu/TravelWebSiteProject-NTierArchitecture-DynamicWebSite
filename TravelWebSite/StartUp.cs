using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using TravelWebSite.business.Abstract;
using TravelWebSite.business.Concrete;
using TravelWebSite.data.Abstract;
using TravelWebSite.data.Concrete.EFCore;

namespace TravelProject
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, EFCoreProductRepository>();
            services.AddScoped<ICategoryRepository, EFCoreCategoryRepository>();
            services.AddScoped<ICityRepository, EFCoreCityRepository>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddControllersWithViews();


        services.Configure<RequestLocalizationOptions>(options =>
        {
            options.DefaultRequestCulture = new RequestCulture("tr-TR"); // Varsayılan olarak Türkçe dilini kullanabilirsiniz.
            options.SupportedCultures = new List<CultureInfo> { new CultureInfo("tr-TR") };
            options.SupportedUICultures = new List<CultureInfo> { new CultureInfo("tr-TR") };
        });
        }



        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();//Yönlendirme kullanılacağını belirtir.
            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapControllerRoute(
                    name: "adminproductlist",
                    pattern: "admin/products",
                    defaults: new { controller = "Admin", action = "ProductList" }
                );
                endpoints.MapControllerRoute(
                    name: "adminproductlist",
                    pattern: "admin/products/{id?}",
                    defaults: new { controller = "Admin", action = "Edit" }
                );
                endpoints.MapControllerRoute(
                    name: "product",
                    pattern: "product/{category?}",
                    defaults: new { controller = "Product", action = "List" }
                );
                endpoints.MapControllerRoute(
                name:"default",
                pattern:"{controller=Home}/{action=Index}/{id?}"
                );
                var supportedCultures = new[]
                {
                    new CultureInfo("tr-TR")
                };

                app.UseRequestLocalization(options =>
                {
                    options.DefaultRequestCulture = new RequestCulture("tr-TR");
                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                });
            });
        }
    }
}