using LaZuittEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace LaZuittEcommerce.Data
{
    public class SeedData
    {
        public static void SeedDataBase(LaZuittContext context)
        {
            context.Database.Migrate();

            if(!context.Course.Any())
            {
                context.Course.AddRange(
                    new Course
                    {
                        Title = "ASP.NET",
                        Description = "ASP.NET is an open source web framework, created by Microsoft, for building modern web apps and services that run on macOS, Linux, Windows, and Docker.  ",
                        Price = 17000,
                        Quantity = 1,
                        Logo = "/images/aspnet-logo.png"
                    },
                new Course
                {
                    Title = "Django",
                    Description = "Django is a free and open-source, Python-based web framework that follows the model–template–views architectural pattern.",
                    Price = 19000,
                    Quantity = 1,
                    Logo = "/images/django-logo.png"
                },

                new Course
                {
                    Title = "Laravel",
                    Description = "Laravel is a free and open-source PHP web framework, created by Taylor Otwell and intended for the development of web applications following the model–view–controller architectural pattern",
                    Price = 16000,
                    Quantity = 1,
                    Logo = "/images/laravel-logo.png"
                },
                new Course
                {
                    Title = "Node.js",
                    Description = "Node.js is an open-source, cross-platform, back-end JavaScript runtime environment that runs on a JavaScript Engine and executes JavaScript code outside a web browser",
                    Price = 14000,
                    Quantity = 1,
                    Logo = "/images/nodejs-logo.png"
                }

                );
                context.SaveChanges();
            }
        }
    }
}
