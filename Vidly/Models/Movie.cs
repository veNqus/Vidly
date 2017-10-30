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
        public DateTime ReleaseDate { get; set; }
        public DateTime AddingDate { get; set; }
        public int AmountInStock { get; set; }

    }
}