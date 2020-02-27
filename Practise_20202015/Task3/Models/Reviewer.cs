using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class Reviewer
    {
        public int ReviewerId { get; set; }
        public string ReviewerName { get; set; }

        public IList<Rating> Ratings { get; set; }
    }
}
