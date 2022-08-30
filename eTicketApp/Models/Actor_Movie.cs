namespace eTicketApp.Models
{
    public class Actor_Movie
    {
        //Many to Many
        public int MovieId { get; set; } //foreign key
        public Movie Movie { get; set; }
        public int ActorId { get; set; } //foreign key
        public Actor Actor { get; set; }
    }
}
