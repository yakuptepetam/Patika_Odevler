using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommand
    {
        public CreateGenreModel Model { get; set; }
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateGenreCommand(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var genre = _dbContext.Genres.SingleOrDefault(x => x.Name == Model.Name);
            if (genre is not null) // genre != null
            {
                throw new InvalidOperationException("Kitap türü zaten mevcut.");
            }
            else
            {
                genre = _mapper.Map<Genre>(Model);
                _dbContext.Genres.Add(genre);
                _dbContext.SaveChanges();
            }
        }
    }
    public class CreateGenreModel
    {
        public string Name { get; set; }
    }
}