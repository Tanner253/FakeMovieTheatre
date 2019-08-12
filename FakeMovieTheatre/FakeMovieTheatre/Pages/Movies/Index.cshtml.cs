using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FakeMovieTheatre.Models;

namespace FakeMovieTheatre.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FakeMovieTheatre.Models.FakeMovieTheatreContext _context;

        public IndexModel(FakeMovieTheatre.Models.FakeMovieTheatreContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
