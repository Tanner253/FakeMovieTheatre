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

        public DbSet<FakeMovieTheatre.Models.Movie> Movie { get; set; }
    }
}
