using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Genres Genre { get; set; }

        public int GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Added Date")]
        public DateTime AddingDate { get; set; }

        [Display(Name = "Number in Stock")]
        public int AmountInStock { get; set; }

    }
}