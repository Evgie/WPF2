using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
