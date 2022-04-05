using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AutherOperations.Query.GetAuthors
{
    public class GetAuthorsQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetAuthorsQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<AuthorsViewModel> Handle()
        {
            var authors = _dbContext.Authors.OrderBy(x => x.Id);
            List<AuthorsViewModel> vm = _mapper.Map<List<AuthorsViewModel>>(authors);
            return vm;
        }
    }
    public class AuthorsViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string BirthOfDate { get; set; }
    }
}