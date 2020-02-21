using System;
using System.Collections.Generic;

namespace Task_2.Models
{
    public partial class TblEpisodeCompanion
    {
        public int EpisodeCompanionId { get; set; }
        public int? EpisodeId { get; set; }
        public int? CompanionId { get; set; }

        //public virtual TblCompanion Companion { get; set; }
        public TblCompanion Companion { get; set; }
    }
}
