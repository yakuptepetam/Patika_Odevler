using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand
    {
        public CreateAuthorModel Model { get; set; }
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateAuthorCommand(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var author = _dbContext.Authors.SingleOrDefault(x => x.Name == Model.Name && x.Surname == Model.Surname);
            if (author is not null) // author != null
            {
                throw new InvalidOperationException("Yazar zaten mevcut.");
            }
            else
            {
                author = _mapper.Map<Author>(Model);
                _dbContext.Authors.Add(author);
                _dbContext.SaveChanges();
            }
        }
    }
    public class CreateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
    }
}