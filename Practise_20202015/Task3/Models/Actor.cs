using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorFName { get; set; }
        public string ActorLName { get; set; }
        public string ActorGender { get; set; }

        public IList<MovieCast> MovieCasts { get; set; }
    }
}
