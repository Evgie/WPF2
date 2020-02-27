using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string DirectorFName { get; set; }
        public string DirectorLName { get; set; }

        public IList<MovieDirection> MovieDirections { get; set; }
    }
}
