using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.DirectorOperations.Commands.DeleteDirector
{
    public class DeleteDirectorCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        public int DirectorId { get; set; }
        public DeleteDirectorCommand(IMovieStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var director = _dbContext.Directors.SingleOrDefault(x => x.Id == DirectorId);
            bool isDirectorHasBook = _dbContext.Movies.Any(x => x.DirectorId == DirectorId);
            if (director is null)
            {
                throw new InvalidOperationException("Yönetmen Bulunamadı.");
            }
            else if (isDirectorHasBook)
            {
                throw new InvalidOperationException("Yönetmenin Filmi Mevcuttur, İlk Önce Yönetmenin Filmini Silinız.");
            }
            else
            {
                _dbContext.Directors.Remove(director);
                _dbContext.SaveChanges();
            }
        }
    }
}