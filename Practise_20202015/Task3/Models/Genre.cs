using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreTitle { get; set; }

        public IList<MovieGenre> MovieGenres { get; set; }
    }
}
