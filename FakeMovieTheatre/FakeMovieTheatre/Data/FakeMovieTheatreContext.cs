﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FakeMovieTheatre.Models
{
    public class FakeMovieTheatreContext : DbContext
    {
        public FakeMovieTheatreContext(DbContextOptions<FakeMovieTheatreContext> options)
            : base(options)
        {
        }
        /// <summary>
        /// adds db set to the database for users to select content from - seeded data
        /// </summary>
        /// <param name="modelBuilder">the model being built is a database and contains the following data</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {

                    ID = 1,
                    Title = "The Never Ending story",
                    Price = 5,
                    Genre = "This is the never ending story, one of the best movies ever! Adventure",
                    ReleaseDate = DateTime.Now,
                    Picture = "images/neverendingstory.jpg"


                },
                new Movie
                {
                    ID = 2,
                    Title = "King Kong",
                    Price = 42,
                    Genre = "Extreemely drawn out and boring until an hour in... suspensful and action!",
                    ReleaseDate = DateTime.Now,
                    Picture = "images/th2.jpg"
                },
                      new Movie
                      {
                          ID = 3,
                          Title = "This is the End",
                          Price = 69,
                          Genre = "Comedy suspensful and action!",
                          ReleaseDate = DateTime.Now,
                          Picture = "images/th.jpg"
                      },
                                  new Movie
                                  {
                                      ID = 4,
                                      Title = "Jurrassic park collection",
                                      Price = 30,
                                      Genre = "Action",
                                      ReleaseDate = DateTime.Now,
                                      Picture = "images/untitled.png"
                                  }
                );

        }

        public DbSet<FakeMovieTheatre.Models.Movie> Movie { get; set; }
    }
}
