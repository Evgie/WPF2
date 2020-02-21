using System;
using System.Collections.Generic;

namespace Task2_1.Models
{
    public partial class TblEpisodeEnemy
    {
        public int EpisodeEnemyId { get; set; }
        public int? EpisodeId { get; set; }
        public int? EnemyId { get; set; }

        //public virtual TblEnemy Enemy { get; set; }
        public TblEnemy Enemy { get; set; }
    }
}
