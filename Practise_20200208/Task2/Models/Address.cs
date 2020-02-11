using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task2.Models
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }

        public Customer Customer { get; set; }
    }
}
