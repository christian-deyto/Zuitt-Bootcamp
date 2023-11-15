using AuthenticationServer.API.Models;
using AuthenticationServer.API.Services.Authenticators;
using AuthenticationServer.API.Services.PasswordHashers;
using AuthenticationServer.API.Services.RefreshTokenRepositories;
using AuthenticationServer.API.Services.TokenGenerators;
using AuthenticationServer.API.Services.TokenValidators;
using AuthenticationServer.API.Services.UserRepositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AuthenticationServer.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            AuthenticationConfiguration authenticationConfiguration = new AuthenticationConfiguration();

            // The parameter "Authentication" here should be the same spelling as in the appsetting.json.
            builder.Configuration.Bind("Authentication", authenticationConfiguration);
            builder.Services.AddSingleton(authenticationConfiguration);

            //Singleton - is a creational design pattern, which ensures that only one object of its kind exists and provides a single point of access to it for any other code.
            builder.Services.AddSingleton<IPasswordHasher, BcryptPasswordHasher>();
            builder.Services.AddSingleton<IUserRepository, InMemoryUserRepositories>();
            builder.Services.AddSingleton<AccessTokenGenerator>();
            builder.Services.AddSingleton<RefreshTokenGenerator>();
            builder.Services.AddSingleton<TokenGenerator>();
            builder.Services.AddSingleton<RefreshTokenValidator>();
            builder.Services.AddSingleton<IRefreshTokenRepository, InMemoryRefreshTokenRepository>();
            builder.Services.AddSingleton<Authenticator>();


            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(o =>
            {


                o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationConfiguration.AccessTokenSecret)),
                    ValidIssuer = authenticationConfiguration.Issuer,
                    ValidAudience = authenticationConfiguration.Audience,
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ClockSkew = TimeSpan.Zero
                };
            });



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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //Added
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}