using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;

namespace WebApi.Application.MovieOperations.Query.GetMovieDetail
{
    public class GetMovieDetailQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int MovieId { get; set; }
        public GetMovieDetailQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public MovieDetailViewModel Handle()
        {
            var movie = _dbContext.Movies.Include(x => x.Genre).Include(x => x.Actor).Include(x => x.Director).Where(movie => movie.Id == MovieId).SingleOrDefault();
            if (movie is null) // movie != null
            {
                throw new InvalidOperationException("Film Bulunamadı.");
            }
            else
            {
                MovieDetailViewModel vm = _mapper.Map<MovieDetailViewModel>(movie);
                return vm;
            }
        }
    }
    public class MovieDetailViewModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
    }
}