using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB.Data.Models
{
    enum Genre
    {
        Fantasy,
        SciFi,
        Anime,
        Steampunk,
        Shenmo,
        Other,
    }

    class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
        
        public Genre Genre { get; set; }
    }
}
