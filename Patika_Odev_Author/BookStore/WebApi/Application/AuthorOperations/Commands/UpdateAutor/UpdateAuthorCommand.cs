using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        public UpdateAuthorModel Model { get; set; }
        private readonly BookStoreDbContext _dbContext;
        public int AuthorId { get; set; }
        public UpdateAuthorCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var author = _dbContext.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Yazar Bulunamadı.");
            }
            else if(_dbContext.Authors.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Surname.ToLower() == Model.Surname.ToLower() && x.Id != AuthorId))
            {
                throw new InvalidOperationException("Aynı İsimli Yazar Zaten Mevcut.");
            }
            else
            {
                author.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? author.Name : Model.Name;
                author.Surname = string.IsNullOrEmpty(Model.Surname.Trim()) ? author.Surname : Model.Surname;
                author.BirthOfDate = string.IsNullOrEmpty(Model.BirthOfDate.Trim()) ? author.BirthOfDate : Convert.ToDateTime(Model.BirthOfDate);
                _dbContext.SaveChanges();
            }
        }
    }
    public class UpdateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
    }
}