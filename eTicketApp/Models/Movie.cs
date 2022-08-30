using eTicketApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Many-Many Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema one to many
        public int CinemaId { get; set; }
        //optional 
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }

        //Producer one to many
        public int ProducerId { get; set; }
        //optional 
        [ForeignKey("ProducerId")]

        public Producer Producer { get; set; }


    }
}
