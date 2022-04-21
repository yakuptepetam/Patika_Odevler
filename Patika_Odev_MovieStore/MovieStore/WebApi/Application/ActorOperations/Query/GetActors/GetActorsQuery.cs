using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.AutherOperations.Query.GetActors
{
    public class GetActorsQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetActorsQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<ActorsViewModel> Handle()
        {
            var actors = _dbContext.Actors.OrderBy(x => x.Id);
            List<ActorsViewModel> vm = _mapper.Map<List<ActorsViewModel>>(actors);
            return vm;
        }
    }
    public class ActorsViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string BirthOfDate { get; set; }
    }
}