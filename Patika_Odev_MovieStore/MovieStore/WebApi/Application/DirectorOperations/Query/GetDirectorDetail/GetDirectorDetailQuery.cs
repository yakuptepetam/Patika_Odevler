using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.DirectorOperations.Query.GetDirectorDetail
{
    public class GetDirectorDetailQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int DirectorId { get; set; }
        public GetDirectorDetailQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public DirectorDetailViewModel Handle()
        {
            var director = _dbContext.Directors.SingleOrDefault(x => x.Id == DirectorId);
            if (director is null) // director != null
            {
                throw new InvalidOperationException("Yönetmen Bulunamadı.");
            }
            else
            {
                DirectorDetailViewModel vm = _mapper.Map<DirectorDetailViewModel>(director);
                return vm;
            }
        }
    }
    public class DirectorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthOfDate { get; set; }
    }
}