using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        public Student Student { get; set; }
    }
}
