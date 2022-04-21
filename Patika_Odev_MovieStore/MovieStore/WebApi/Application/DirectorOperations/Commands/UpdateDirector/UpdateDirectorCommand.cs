using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.DirectorOperations.Commands.UpdateDirector
{
    public class UpdateDirectorCommand
    {
        public UpdateDirectorModel Model { get; set; }
        private readonly IMovieStoreDbContext _dbContext;
        public int DirectorId { get; set; }
        public UpdateDirectorCommand(IMovieStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var director = _dbContext.Directors.SingleOrDefault(x => x.Id == DirectorId);
            if (director is null)
            {
                throw new InvalidOperationException("Yönetmen Bulunamadı.");
            }
            else if (_dbContext.Directors.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Surname.ToLower() == Model.Surname.ToLower() && x.Id != DirectorId))
            {
                throw new InvalidOperationException("Aynı İsimli Yönetmen Zaten Mevcut.");
            }
            else
            {
                director.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? director.Name : Model.Name;
                director.Surname = string.IsNullOrEmpty(Model.Surname.Trim()) ? director.Surname : Model.Surname;
                director.BirthOfDate = string.IsNullOrEmpty(Model.BirthOfDate.Trim()) ? director.BirthOfDate : Convert.ToDateTime(Model.BirthOfDate);
                _dbContext.SaveChanges();
            }
        }
    }
    public class UpdateDirectorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
    }
}