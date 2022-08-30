namespace eTicketApp.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships

        //producer can have multiple movies
        public List<Movie> Movies { get; set; }
    }
}
