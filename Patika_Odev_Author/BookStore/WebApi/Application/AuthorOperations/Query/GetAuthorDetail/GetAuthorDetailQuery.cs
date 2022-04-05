using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Query.GetAuthorDetail
{
    public class GetAuthorDetailQuery 
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int AuthorId { get; set; }
        public GetAuthorDetailQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public AuthorDetailViewModel Handle()
        {
            var author = _dbContext.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null) // author != null
            {
                throw new InvalidOperationException("Yazar Bulunamadı.");
            }
            else
            {
                AuthorDetailViewModel vm = _mapper.Map<AuthorDetailViewModel>(author);
                return vm;
            }
        }
    }
    public class AuthorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthOfDate { get; set; }
    }
}