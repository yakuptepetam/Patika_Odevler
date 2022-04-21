using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public DateTime Year { get; set; }
    }
}