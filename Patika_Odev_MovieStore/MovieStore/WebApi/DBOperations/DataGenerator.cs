using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {
                // Look for any Movie.
                if (context.Movies.Any())
                {
                    return;   // Data was already seeded
                }

                context.Directors.AddRange(
                    new Director
                    {
                        // Id = 1,
                        Name = "Keenen Ivory",
                        Surname = "Wayans",
                        BirthOfDate = new DateTime(1958, 06, 08)
                    },
                    new Director
                    {
                        // Id = 1,
                        Name = "Felix Gray",
                        Surname = "Gray",
                        BirthOfDate = new DateTime(1969, 07, 17)
                    },
                    new Director
                    {
                        // Id = 1,
                        Name = "Guy",
                        Surname = "Ritchie",
                        BirthOfDate = new DateTime(1968, 09, 10)
                    }
                );

                context.Actors.AddRange(
                    new Actor
                    {
                        // Id = 1,
                        Name = "Marlon",
                        Surname = "Wayans",
                        BirthOfDate = new DateTime(1972, 07, 23)
                    },
                    new Actor
                    {
                        // Id = 1,
                        Name = "Dwayne",
                        Surname = "Johnson",
                        BirthOfDate = new DateTime(1972, 05, 02)
                    },
                    new Actor
                    {
                        // Id = 1,
                        Name = "Robert",
                        Surname = "Downey Jr",
                        BirthOfDate = new DateTime(1965, 04, 04)
                    }
                );

                context.Genres.AddRange(
                    new Genre
                    {
                        Name = "Komedi",
                    },
                    new Genre
                    {
                        Name = "Aksiyon",
                    },
                    new Genre
                    {
                        Name = "Dedektif",
                    }
                );

                context.Movies.AddRange(
                    new Movie
                    {
                        // Id = 1,
                        Name = "Korkunç Bir Film",
                        GenreId = 1,
                        ActorId = 1,
                        DirectorId = 1,
                        Year = new DateTime(2011, 06, 12)
                    },
                    new Movie
                    {
                        // Id = 2,
                        Name = "Hızlı ve Öfkeli",
                        GenreId = 2,
                        ActorId = 2,
                        DirectorId = 2,
                        Year = new DateTime(1915, 05, 23)
                    },
                    new Movie
                    {
                        // Id = 3,
                        Name = "Sherlock Holmes",
                        GenreId = 3,
                        ActorId = 3,
                        DirectorId = 3,
                        Year = new DateTime(2009, 12, 21)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}