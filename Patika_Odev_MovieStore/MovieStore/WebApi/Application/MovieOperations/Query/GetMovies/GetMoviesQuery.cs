using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Common;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.MovieOperations.Query.GetMovies
{
    public class GetMoviesQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetMoviesQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<MoviesViewModel> Handle()
        {
            var movieList = _dbContext.Movies.Include(x => x.Genre).Include(x => x.Actor).Include(x => x.Director).OrderBy(x => x.Id).ToList<Movie>();
            List<MoviesViewModel> vm = _mapper.Map<List<MoviesViewModel>>(movieList);
            return vm;
        }
    }
    public class MoviesViewModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
    }
}