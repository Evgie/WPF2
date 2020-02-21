using System;
using System.Collections.Generic;

namespace Task_2.Models
{
    public partial class TblCompanion
    {
        public TblCompanion()
        {
            TblEpisodeCompanion = new HashSet<TblEpisodeCompanion>();
        }

        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }

        //public virtual ICollection<TblEpisodeCompanion> TblEpisodeCompanion { get; set; }
        public ICollection<TblEpisodeCompanion> TblEpisodeCompanion { get; set; }
    }
}
