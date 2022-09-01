using eTicketApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicketApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Price" )]
        public double Price { get; set; }

        [Display(Name = "Image")]
        public string ImageURL { get; set; }

        [Display(Name = "Start Date: ")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date: ")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Category")]
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
