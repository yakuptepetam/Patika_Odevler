using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.ActorOperations.Commands.DeleteActor
{
    public class DeleteActorCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        public int ActorId { get; set; }
        public DeleteActorCommand(IMovieStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var actor = _dbContext.Actors.SingleOrDefault(x => x.Id == ActorId);
            bool isActorHasBook = _dbContext.Movies.Any(x => x.ActorId == ActorId);
            if (actor is null)
            {
                throw new InvalidOperationException("Aktör Bulunamadı.");
            }
            else if (isActorHasBook)
            {
                throw new InvalidOperationException("Aktörün Filmi Mevcuttur, İlk Önce Aktörün Filmini Silinız.");
            }
            else
            {
                _dbContext.Actors.Remove(actor);
                _dbContext.SaveChanges();
            }
        }
    }
}