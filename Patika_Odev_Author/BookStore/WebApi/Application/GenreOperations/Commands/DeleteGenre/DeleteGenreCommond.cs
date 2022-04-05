using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.Commands.DeleteGenre
{
    public class DeleteGenreCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public int GenreId { get; set; }
        public DeleteGenreCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var genre = _dbContext.Genres.SingleOrDefault(x=>x.Id == GenreId);
            if(genre is null)
            {
                throw new InvalidOperationException("Kitap Türü Bulunamadı.");
            }
            else
            {
                _dbContext.Genres.Remove(genre);
                _dbContext.SaveChanges(); 
            }
        }
    }
}