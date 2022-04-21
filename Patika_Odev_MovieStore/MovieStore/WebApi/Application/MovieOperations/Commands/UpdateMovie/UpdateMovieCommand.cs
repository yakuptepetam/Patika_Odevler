using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.MovieOperations.Commands.UpdateMovie
{
    public class UpdateMovieCommand
    {
        public UpdateMovieModel Model { get; set; }
        private readonly IMovieStoreDbContext _dbContext;
        public int MovieId { get; set; }
        public UpdateMovieCommand(IMovieStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var movie = _dbContext.Movies.SingleOrDefault(x => x.Id == MovieId);
            if (movie is null)
            {
                throw new InvalidOperationException("Film Bulunamadı.");
            }
            else if (_dbContext.Movies.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Id != MovieId))
            {
                throw new InvalidOperationException("Aynı İsimli Film Zaten Mevcut.");
            }
            else
            {
                // movie.GenreId = Model.GenreId != default ? Model.GenreId : movie.GenreId;
                // movie.PageCount = Model.PageCount != default ? Model.PageCount : movie.PageCount;
                // movie.PublishDate = Model.PublishDate != default ? Model.PublishDate : movie.PublishDate;
                // movie.Title = Model.Title != default ? Model.Title : movie.Title;
                _dbContext.SaveChanges();
            }
        }
    }
    public class UpdateMovieModel
    {
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int ActorId { get; set; }
        public int DirectorId { get; set; }
        public DateTime Year { get; set; }
    }
}