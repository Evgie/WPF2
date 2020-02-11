using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }

        public ICollection<Country> Countries { get; set; }
    }
}
