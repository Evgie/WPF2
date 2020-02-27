using System;
using System.Collections.Generic;

namespace Task2_1.Models
{
    public partial class TblEnemy
    {
        public TblEnemy()
        {
            TblEpisodeEnemy = new HashSet<TblEpisodeEnemy>();
        }

        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string Description { get; set; }

        //public virtual ICollection<TblEpisodeEnemy> TblEpisodeEnemy { get; set; }
        public ICollection<TblEpisodeEnemy> TblEpisodeEnemy { get; set; }
    }
}
