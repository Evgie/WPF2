using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ViewModel.AdminViewModel
{
    public class CustomersListViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        public CustomersListViewModel()
        {
            //if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            //    return;

            //this.Customers = new ObservableCollection<Customer>();

            this.InitializeCustomers();
        }

        private void InitializeCustomers()
        {
            using (var context = new MyStoreDbContext())
            {
                var tempProducts = context.Customers
                    .Include(c => c.Orders)
                    .ThenInclude(o => o.OrderItems)
                    .ToList();
                this.Customers = new ObservableCollection<Customer>(tempProducts);
            }
        }
    }
}
