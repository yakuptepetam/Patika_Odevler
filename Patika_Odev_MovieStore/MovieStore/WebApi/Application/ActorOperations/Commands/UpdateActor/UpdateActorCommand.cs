using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.ActorOperations.Commands.UpdateActor
{
    public class UpdateActorCommand
    {
        public UpdateActorModel Model { get; set; }
        private readonly IMovieStoreDbContext _dbContext;
        public int ActorId { get; set; }
        public UpdateActorCommand(IMovieStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var actor = _dbContext.Actors.SingleOrDefault(x => x.Id == ActorId);
            if (actor is null)
            {
                throw new InvalidOperationException("Aktör Bulunamadı.");
            }
            else if (_dbContext.Actors.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Surname.ToLower() == Model.Surname.ToLower() && x.Id != ActorId))
            {
                throw new InvalidOperationException("Aynı İsimli Aktör Zaten Mevcut.");
            }
            else
            {
                actor.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? actor.Name : Model.Name;
                actor.Surname = string.IsNullOrEmpty(Model.Surname.Trim()) ? actor.Surname : Model.Surname;
                actor.BirthOfDate = string.IsNullOrEmpty(Model.BirthOfDate.Trim()) ? actor.BirthOfDate : Convert.ToDateTime(Model.BirthOfDate);
                _dbContext.SaveChanges();
            }
        }
    }
    public class UpdateActorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
    }
}