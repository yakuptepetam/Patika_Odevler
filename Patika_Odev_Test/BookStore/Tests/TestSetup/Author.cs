using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Authors
    {
        public static void AddAuthors(this BookStoreDBContext context)
        {
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
        }
    }
}