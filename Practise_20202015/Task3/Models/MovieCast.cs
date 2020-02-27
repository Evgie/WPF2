using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class MovieCast
    {
        public int MovieCastId { get; set; }
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        public string Role { get; set; }

        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
