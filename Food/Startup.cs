using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Food.Controllers;
using Food.Data;
using Food.Data.Repositories;
using Food.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace Food
{
    public class Startup
    {
        //trusted_connection=true - jak serwer na innej maszynie to wyrzuciæ
        private const string securityKey = "gjknlfgdnjkl32423";
        private Configuration configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration.GetSection("Configuration").Get<Configuration>();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<FoodContext>(options => options.UseSqlServer(configuration.ConnectionString));
            services.AddScoped<MealRepository>();
            services.AddScoped<IngredientRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<IngredientCategoryRepository>();
            services.AddSingleton<Configuration>(configuration);
            services.AddHostedService<RemoveUnactiveUsersService>();

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
                             var tokenValue = context.Request.Cookies.First(cookie => cookie.Key == "token").Value;
                             var tokenCookie = new Cookie("token", tokenValue);

                             if (!tokenCookie.Expired)
                             {
                                 context.Token = tokenValue;
                             }
                         }

                         return Task.CompletedTask;
                     }
                 };
             });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var foodContext = scope.ServiceProvider.GetService<FoodContext>();
                foodContext.Database.Migrate();
            }

            app.UseStatusCodePages(async context =>
            {
                if (context.HttpContext.Response.StatusCode == (int)HttpStatusCode.Unauthorized)
                {
                    context.HttpContext.Response.Redirect($"/{nameof(UserController).Replace("Controller", "")}");
                }
            });

            app.Use(async (context, nextTask) =>
            {
                var cspNonce = Guid.NewGuid().ToString("n").Substring(0, 20);

                context.Items.Add("CspNonce", cspNonce);

                var contentSecurityHeaderValue =
                    $"script-src 'nonce-{cspNonce}'";

                context.Response.Headers.Remove("Content-Security-Policy");
                context.Response.Headers.Add("Content-Security-Policy", contentSecurityHeaderValue);

                await nextTask.Invoke();
            });

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=ManageMeals}/{action=Index}");

            });
            app.UseStaticFiles();
        }
    }
}
