using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food.Data;
using Food.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Food
{
    public class Startup
    {
        //trusted_connection=true - jak serwer na innej maszynie to wyrzuciæ
        private string connectionString = "Server=KOMPUTER-KARINA\\SQLEXPRESS;Database=Food;Trusted_Connection=True;";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<FoodContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<MealRepository>();
            services.AddScoped<IngredientRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=ManageMeals}/{action=Index}/{userId=1}");
                
            });
            app.UseStaticFiles();
        }
    }
}
