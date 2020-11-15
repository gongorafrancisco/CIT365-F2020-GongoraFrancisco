using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Legacy",
                        ReleaseDate = DateTime.Parse("1993-7-3"),
                        Genre = "History",
                        Price = 6.99M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "The Testaments of One Fold and One Shepherd",
                        ReleaseDate = DateTime.Parse("2000-3-24"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "Finding Faith in Christ",
                        ReleaseDate = DateTime.Parse("2003-2-23"),
                        Genre = "Short",
                        Price = 2.99M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Western",
                        Price = 19.95M,
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}