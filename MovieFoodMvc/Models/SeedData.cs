using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieFoodMvc.Data;
using System;
using System.Linq;

namespace MovieFoodMvc.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieFoodMvcContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieFoodMvcContext>>()))
            {
                // Look for any movies.
                //if (context.Movie.Any() || context.Food.Any())
                //{
                //    return;   // DB has been seeded
                //}

                context.Movie.AddRange(
                    new Movie
                    {
                        ID = 1953772,
                        MovieName = "Joker",
                        SalePrice = 8.99M,
                        StudioCutPercentage = 0.75M,
                        Quantity = 419
                    },

                    new Movie()
                    {
                        ID = 2817721,
                        MovieName = "Toy Story 4",
                        SalePrice = 7.99M,
                        StudioCutPercentage = 0.9M,
                        Quantity = 112
                    },
                    new Movie()
                    {
                        ID = 2177492,
                        MovieName = "Hustlers",
                        SalePrice = 8.49M,
                        StudioCutPercentage = 0.67M,
                        Quantity = 51
                    },
                    new Movie()
                    {
                        ID = 2747119,
                        MovieName = "Downton Abbey",
                        SalePrice = 8.99M,
                        StudioCutPercentage = 0.72M,
                        Quantity = 214
                    }
                );
                context.SaveChanges();

                context.Food.AddRange(
                    new Food()
                    {
                        ID = 14,
                        Name = "Milk Duds",
                        SalePrice = 4.99M,
                        UnitPrice = 1.69M,
                        Quantity = 43
                    },
                    new Food()
                    {
                        ID = 3,
                        Name = "Sour Gummy Worms",
                        SalePrice = 4.89M,
                        UnitPrice = 1.13M,
                        Quantity = 319
                    },
                    new Food()
                    {
                        ID = 18,
                        Name = "Large Soda",
                        SalePrice = 5.69M,
                        UnitPrice = 0.47M,
                        Quantity = 319
                    },
                    new Food()
                    {
                        ID = 19,
                        Name = "X-Large Soda",
                        SalePrice = 6.19M,
                        UnitPrice = 0.59M,
                        Quantity = 252
                    },
                    new Food()
                    {
                        ID = 1,
                        Name = "Large Popcorn",
                        SalePrice = 5.59M,
                        UnitPrice = 1.12M,
                        Quantity = 217
                    });
                context.SaveChanges();
            }
        }
    }
}
