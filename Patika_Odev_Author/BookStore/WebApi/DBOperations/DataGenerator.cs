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
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                // Look for any book.
                if (context.Books.Any())
                {
                    return;   // Data was already seeded
                }

                context.Authors.AddRange(
                    new Author
                    {
                        // Id = 1,
                        Name = "Eric",
                        Surname = "Ries",
                        BirthOfDate = new DateTime(1978, 09, 22)
                    },
                    new Author
                    {
                        // Id = 1,
                        Name = "Charlotte Perkins",
                        Surname = "Gilman",
                        BirthOfDate = new DateTime(1860, 07, 03)
                    },
                    new Author
                    {
                        // Id = 1,
                        Name = "Victor",
                        Surname = "Hugo",
                        BirthOfDate = new DateTime(1802, 02, 26)
                    }
                );

                context.Genres.AddRange(
                    new Genre
                    {
                        // Id = 1,
                        Name = "Personal Growth",
                    },
                    new Genre
                    {
                        // Id = 1,
                        Name = "Science Fiction",
                    },
                    new Genre
                    {
                        // Id = 1,
                        Name = "Romance",
                    }
                );

                context.Books.AddRange(
                    new Book
                    {
                        // Id = 1,
                        Title = "Lean Startup",
                        GenreId = 1, // Personal Growth
                        AuthorId = 1, // Eric Ries
                        PageCount = 335,
                        PublishDate = new DateTime(2011, 06, 12)
                    },
                    new Book
                    {
                        // Id = 2,
                        Title = "Herland",
                        GenreId = 2, // Science Fiction
                        AuthorId = 2, // Charlotte Perkins Gilman
                        PageCount = 165,
                        PublishDate = new DateTime(1915, 05, 23)
                    },
                    new Book
                    {
                        // Id = 3,
                        Title = "Sefiller",
                        GenreId = 3, // Romance
                        AuthorId = 3, // Victor Hugo
                        PageCount = 510,
                        PublishDate = new DateTime(1862, 12, 21)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}