using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstRazorPage.Models;

namespace MyFirstRazorPage.Data
{
    public class RazorPageMoviesContext : DbContext
    {
        public RazorPageMoviesContext (DbContextOptions<RazorPageMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstRazorPage.Models.Movie> Movie { get; set; }
    }
}
