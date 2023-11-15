using ECommerceCapstone.Data;
using ECommerceCapstone.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ECommerceCapstone.Data
{
    public class SeedData
    {
        public static void SeedDataBase(ECommerceContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Exhaust Systems",
                        Description = "Vroom Vroom!.",
                        Price = 17000,
                        Archived = false
                    },
                    new Product
                    {
                        Name = "Mags",
                        Description = "Nice black mags!.",
                        Price = 19000,
                        Archived = false
                    },
                    new Product
                    {
                        Name = "Spark Plug",
                        Description = "Save your fuel!.",
                        Price = 16000,
                        Archived = false
                    },
                    new Product
                    {
                        Name = "Ceramic coat",
                        Description = "No scratches!.",
                        Price = 14000,
                        Archived = false
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
