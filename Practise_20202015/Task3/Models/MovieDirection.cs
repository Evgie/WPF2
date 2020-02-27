using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class MovieDirection
    {
        public int MovieDirectionId { get; set; }
        public int DirectorId { get; set; }
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
        public Director Director { get; set; }
    }
}
