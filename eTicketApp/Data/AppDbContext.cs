using eTicketApp.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //define the actor_movie builder

            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            //define the actor_movie to be the joining model 

            //movie-side
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            //actor side
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(a => a.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        //define for each model
        // used to query and save instances of each model
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
