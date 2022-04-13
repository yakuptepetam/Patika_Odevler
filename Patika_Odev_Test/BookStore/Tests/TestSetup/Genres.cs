using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Genres
    {
        public static void AddGenres(this BookStoreDBContext context)
        {
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
        }
    }
}