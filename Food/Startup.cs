using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Data;
using Food.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace Food
{
    public class Startup
    {
        //trusted_connection=true - jak serwer na innej maszynie to wyrzuciæ
        private string connectionString = "Server=KOMPUTER-KARINA\\SQLEXPRESS;Database=Food;Trusted_Connection=True;";
        private const string securityKey = "gjknlfgdnjkl32423";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<FoodContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<MealRepository>();
            services.AddScoped<IngredientRepository>();
            services.AddScoped<UserRepository>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
             {
                 options.RequireHttpsMetadata = false;
                 options.SaveToken = true;
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuerSigningKey = false,
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(securityKey)),
                     ValidateIssuer = false,
                     ValidateAudience = false
                 };
                 options.Events = new JwtBearerEvents
                 {
                     OnMessageReceived = context =>
                     {
                         var doesTokenCookieExist = context.Request.Cookies.Any(cookie => cookie.Key == "token");

                         if (doesTokenCookieExist)
                         {
                             context.Token = context.Request.Cookies.First(cookie => cookie.Key == "token").Value;
                         }

                         return Task.CompletedTask;
                     }
                 };
             });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
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
