using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Model.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Active { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int ManagerId { get; set; }
        public ObservableCollection<Order> Orders { get; set; }
    }
}
