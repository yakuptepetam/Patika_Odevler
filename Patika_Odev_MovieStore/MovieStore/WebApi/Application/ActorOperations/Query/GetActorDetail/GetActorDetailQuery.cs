using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.ActorOperations.Query.GetActorDetail
{
    public class GetActorDetailQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int ActorId { get; set; }
        public GetActorDetailQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public ActorDetailViewModel Handle()
        {
            var actor = _dbContext.Actors.SingleOrDefault(x => x.Id == ActorId);
            if (actor is null) // actor != null
            {
                throw new InvalidOperationException("Aktör Bulunamadı.");
            }
            else
            {
                ActorDetailViewModel vm = _mapper.Map<ActorDetailViewModel>(actor);
                return vm;
            }
        }
    }
    public class ActorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthOfDate { get; set; }
    }
}