using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Books
    {
        public static void AddBooks(this BookStoreDBContext context)
        {
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
        }
    }
}