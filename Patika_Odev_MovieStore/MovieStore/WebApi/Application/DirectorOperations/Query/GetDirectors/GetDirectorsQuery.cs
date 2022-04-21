using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.AutherOperations.Query.GetDirectors
{
    public class GetDirectorsQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetDirectorsQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<DirectorsViewModel> Handle()
        {
            var directors = _dbContext.Directors.OrderBy(x => x.Id);
            List<DirectorsViewModel> vm = _mapper.Map<List<DirectorsViewModel>>(directors);
            return vm;
        }
    }
    public class DirectorsViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string BirthOfDate { get; set; }
    }
}