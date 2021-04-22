using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Promocodes.Extensions;
using Promocodes.Models;
using Promocodes.Repository;
using Promocodes.Services;

namespace Promocodes
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Build connect string based on env for docker connection
            var server = Configuration["DBServer"] ?? "localhost";
            var port = Configuration["DBPort"] ?? "1433";
            var user = Configuration["DBUser"] ?? "sa"; //Not in production
            var password = Configuration["DBPassword"] ?? "MyPassword1234";
            var database = Configuration["Database"] ?? "Promocodes";

            services.AddDbContext<PromotionCodeDbContext>(options =>
                options.UseSqlServer($"Server={server}, {port};Initial Catalog={database};User ID = {user};Password={password}"));
            
            services.AddControllers();

            services.AddHttpClient();
                        
            //Register the repository s.t the DI can auto supply it whenever requested
            services.AddTransient<IPromotionCode, PromotionCodeServices>();

            services.ConfigureCors();

            services.ConfigureIISIntegration();

            services.ConfigureAuthentication();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
