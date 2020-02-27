using System;
using System.Collections.Generic;

namespace Task_2.Models
{
    public partial class TblEpisode
    {
        public int EpisodeId { get; set; }
        public int? SeriesNumber { get; set; }
        public int? EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime? EpisodeDate { get; set; }
        public int? AuthorId { get; set; }
        public int? DoctorId { get; set; }
        public string Notes { get; set; }

        //public virtual TblAuthor Author { get; set; }
        //public virtual TblDoctor Doctor { get; set; }
        public TblAuthor Author { get; set; }
        public TblDoctor Doctor { get; set; }
        public IList<TblEpisodeEnemy> EpisodeEnemies { get; set; }
    }
}
