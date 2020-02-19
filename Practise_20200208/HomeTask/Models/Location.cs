using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeTask.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }
        [StringLength(25)]
        public string StreetAddress { get; set; }
        [StringLength(12)]
        public string PostalCode { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(12)]
        public string StateProvince { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
