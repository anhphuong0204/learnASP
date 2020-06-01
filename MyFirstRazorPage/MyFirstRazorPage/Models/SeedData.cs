﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyFirstRazorPage.Data;

namespace MyFirstRazorPage.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPageMoviesContext>>()))
            {
                if (context.Movie.Any())
                    return;

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseTime = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "A"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseTime = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "B",
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseTime = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "C",
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseTime = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "D",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
