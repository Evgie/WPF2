using System;
using System.Collections.Generic;

namespace Task2_1.Models
{
    public partial class TblDoctor
    {
        public TblDoctor()
        {
            TblEpisode = new HashSet<TblEpisode>();
        }

        public int DoctorId { get; set; }
        public int? DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? FirstEpisodeDate { get; set; }
        public DateTime? LastEpisodeDate { get; set; }

        //public virtual ICollection<TblEpisode> TblEpisode { get; set; }
        public virtual ICollection<TblEpisode> TblEpisode { get; set; }
    }
}
