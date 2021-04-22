using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Promocodes.Repository;

namespace Promocodes.Extensions
{
    public static class ServiceExtensions
    {
        //Configure Cross-Origin Resource Sharing (CORS)
        //Restricts acces rights to applications from other domains
        public static void ConfigureCors(this IServiceCollection services) => 
            services.AddCors(options => 
        {
            options.AddPolicy("CorsPolicy", builder => 
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );
        });

        //Configure IIS to cater for self hosting

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options => {

            });

        //Configure Authentication
        public static void ConfigureAuthentication(this IServiceCollection services) =>
            services.AddAuthentication(opt =>{
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options => {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,    //Valid Issuer of the token
                    ValidateAudience = true,  //Valid receipient?
                    ValidateLifetime = true,  //Token has not expired
                    ValidateIssuerSigningKey = true,  //Valid and trusted sign in key
                    
                    ValidIssuer = "http://localhost:5000",
                    ValidAudience = "http://localhost:5000",
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("testSecretKey@1983"))
                    
                };
            });
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config) =>
            services.AddDbContext<PromotionCodeDbContext>(opts =>{
                opts.UseSqlServer(config.GetConnectionString("sqlconnection"));
            });
    }
}