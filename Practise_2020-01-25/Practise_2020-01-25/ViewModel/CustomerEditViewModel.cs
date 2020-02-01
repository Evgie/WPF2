using Practise_2020_01_25.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_2020_01_25.ViewModel
{
    public class CustomerEditViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        public CustomerEditViewModel()
        {
            this.Customers = new ObservableCollection<Customer>()
            {
                new Customer{FirstName = "Tetyana", LastName = "Ryzhik", City = "Kharkiv"},
                new Customer{FirstName = "Andrew", LastName = "Fedorchenko", City = "Kharkiv"},
                new Customer{FirstName = "Vlad", LastName = "Radchenko", City = "Kharkiv"},
            };
        }
    }
}
