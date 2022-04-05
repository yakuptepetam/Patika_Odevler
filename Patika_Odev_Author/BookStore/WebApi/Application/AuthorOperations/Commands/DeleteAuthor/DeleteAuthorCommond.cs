using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public int AuthorId { get; set; }
        public DeleteAuthorCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var author = _dbContext.Authors.SingleOrDefault(x => x.Id == AuthorId);
            bool isAuthorHasBook = _dbContext.Books.Any(x => x.AuthorId == AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Yazar Bulunamadı.");
            }
            else if (isAuthorHasBook)
            {
                throw new InvalidOperationException("Yazarın Kitabı Mevcuttur, İlk Önce Yazarın Kiştaplarını Silinız.");
            }
            else
            {
                _dbContext.Authors.Remove(author);
                _dbContext.SaveChanges();
            }
        }
    }
}