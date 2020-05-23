using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFirstRazorPage.Data;
using MyFirstRazorPage.Models;

namespace MyFirstRazorPage.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyFirstRazorPage.Data.RazorPageMoviesContext _context;

        public IndexModel(MyFirstRazorPage.Data.RazorPageMoviesContext context)
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
