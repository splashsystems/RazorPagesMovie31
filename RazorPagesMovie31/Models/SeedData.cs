using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie31.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie31.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovie31Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovie31Context>>()))
            {
                // Look for any Movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "FlubbaDubba",
                        ReleaseDate = DateTime.Parse("1949-8-24"),
                        Genre = "Tortoise",
                        Price = 232.00M,
                        //Rating = "T5"
                    },

                    new Movie
                    {
                        Title = "Chimichanga",
                        ReleaseDate = DateTime.Parse("2015-12-24"),
                        Genre = "Sea Movie",
                        Price = 125.50M,
                        //Rating = "T5"
                    },

                    new Movie
                    {
                        Title = "Swim",
                        ReleaseDate = DateTime.Parse("2018-11-27"),
                        Genre = "Sea Movie",
                        Price = 58.98M,
                        //Rating = "T5"
                    },

                    new Movie
                    {
                        Title = "Boxer",
                        ReleaseDate = DateTime.Parse("2020-1-1"),
                        Genre = "Western Box Movie",
                        Price = 15.00M,
                        //Rating = "T5"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
