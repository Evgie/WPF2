using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int MovieId { get; set; }
        public int ReviewerId { get; set; }
        public int ReviewerStars { get; set; }
        public int NumOfRatings { get; set; }

        public Movie Movie { get; set; }
        public Reviewer Reviewer { get; set; }
    }
}
