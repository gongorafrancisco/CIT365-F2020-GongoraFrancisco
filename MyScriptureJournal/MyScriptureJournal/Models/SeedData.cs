using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Check if there are any scripture entry
                if (context.Scripture.Any())
                {
                    return; // DB has been seeded
                }
                context.Scripture.AddRange(

                    new Scripture
                    {
                        DateAdded = DateTime.Now,
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = "1",
                        Note = "I will go and do because I know"
                    },

                    new Scripture
                    {
                        DateAdded = DateTime.Now,
                        Book = "2 Nephi",
                        Chapter = 2,
                        Verse = "25",
                        Note = "It was the Heavenly Father's plan that Adam and Eve were expelled from the Eden so we can come to earth and have joy"
                    },

                    new Scripture
                    {
                        DateAdded = DateTime.Now,
                        Book = "Alma",
                        Chapter = 32,
                        Verse = "21",
                        Note = "Faith is not a perfect knowledge"
                    },

                    new Scripture
                    {
                        DateAdded = DateTime.Now,
                        Book = "Helaman",
                        Chapter = 5,
                        Verse = "12",
                        Note = "Keep far from the devil and build a foundation on Christ"
                    },

                    new Scripture
                    {
                        DateAdded = DateTime.Now,
                        Book = "Matthew",
                        Chapter = 5,
                        Verse = "14-16",
                        Note = "We should be witnesses of Christ everywhere"
                    },

                    new Scripture
                    {
                        DateAdded = DateTime.Now,
                        Book = "Luke",
                        Chapter = 24,
                        Verse = "36-39",
                        Note = "Resurrected bodies are made of bond and flesh"
                    },

                    new Scripture
                    {
                        DateAdded = DateTime.Now,
                        Book = "Jhon",
                        Chapter = 17,
                        Verse = "3",
                        Note = "Get to know Heavenly Father and Christ and all their work is Eternal life"
                    }

                    );
                context.SaveChanges();
            }
        }

    }
}
