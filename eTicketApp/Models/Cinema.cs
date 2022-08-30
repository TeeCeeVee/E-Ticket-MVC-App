using System.ComponentModel.DataAnnotations;

namespace eTicketApp.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        //One to Many
        //Cinema can have many movies
        public List<Movie> Movies { get; set; }

    }
}
