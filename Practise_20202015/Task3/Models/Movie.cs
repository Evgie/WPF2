using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public int MovieYear { get; set; }
        public int MovieTime { get; set; }
        public string MovieLang { get; set; }
        public DateTime MovieDtRel { get; set; }
        public string MovieRelCountry { get; set; }

        public IList<Rating> Ratings { get; set; }
        public IList<MovieGenre> MovieGenres { get; set; }
        public IList<MovieCast> MovieCasts { get; set; }
        public IList<MovieDirection> MovieDirections { get; set; }
    }
}
