using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.Query.GetGenreDetail
{
    public class GetGenreDetailQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int GenreId { get; set; }
        public GetGenreDetailQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public GenreDetailViewModel Handle()
        {
            var genre = _dbContext.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenreId);
            if (genre is null) // genre != null
            {
                throw new InvalidOperationException("Kitap Türü Bulunamadı.");
            }
            else
            {
                GenreDetailViewModel vm = _mapper.Map<GenreDetailViewModel>(genre);
                return vm;
            }
        }
    }
    public class GenreDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}