using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstRazorPage.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Tittle { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseTime { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
