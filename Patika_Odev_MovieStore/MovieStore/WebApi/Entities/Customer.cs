using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
    }
}