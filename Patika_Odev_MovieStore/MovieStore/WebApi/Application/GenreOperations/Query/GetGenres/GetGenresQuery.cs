using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.Query.GetGenres
{
    public class GetGenresQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetGenresQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<GenresViewModel> Handle()
        {
            var genres = _dbContext.Genres.Where(x => x.IsActive).OrderBy(x => x.Id);
            List<GenresViewModel> vm = _mapper.Map<List<GenresViewModel>>(genres);
            return vm;
        }
    }
    public class GenresViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}