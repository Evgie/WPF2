using System;
using System.Collections.Generic;

namespace Task2_1.Models
{
    public partial class TblAuthor
    {
        public TblAuthor()
        {
            TblEpisode = new HashSet<TblEpisode>();
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        //public virtual ICollection<TblEpisode> TblEpisode { get; set; }
        public ICollection<TblEpisode> TblEpisode { get; set; }
    }
}
