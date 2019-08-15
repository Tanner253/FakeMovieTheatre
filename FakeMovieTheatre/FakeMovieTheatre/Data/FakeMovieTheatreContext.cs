using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FakeMovieTheatre.Models
{
    public class FakeMovieTheatreContext : DbContext
    {
        public FakeMovieTheatreContext (DbContextOptions<FakeMovieTheatreContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    ID = 1,
                    Title = "The Never Ending story",
                    Price = 5,
                    Genre = "Name a pangolin and receive a plush.",
                    ReleaseDate = DateTime.Now

                });
               
        }

        public DbSet<FakeMovieTheatre.Models.Movie> Movie { get; set; }
    }
}
