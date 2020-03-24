using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ViewModel.AdminViewModel
{
    public class CustomersListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Customer> customers;
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return this.customers;
            }
            set
            {
                if (this.customers == value)
                    return;

                this.customers = value;
                this.OnPropertyChanged(nameof(this.Customers));
            }
        }

        private OrdersListViewModel ordersListViewModel;
        public OrdersListViewModel OrdersListViewModel
        {
            get
            {
                return this.ordersListViewModel;
            }
            set
            {
                if (this.ordersListViewModel == value)
                    return;

                this.ordersListViewModel = value;
                this.OnPropertyChanged(nameof(this.OrdersListViewModel));
            }
        }

        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            get
            {
                return this.selectedCustomer;
            }
            set
            {
                if (this.selectedCustomer == value)
                    return;

                this.selectedCustomer = value;
                this.OnPropertyChanged(nameof(this.SelectedCustomer));
                this.OrdersListViewModel = new OrdersListViewModel(this.SelectedCustomer.Orders);
            }
        }

        public CustomersListViewModel()
        {
            this.InitializeCustomers();
        }

        private void InitializeCustomers()
        {
            var context = new MyStoreDbContext();
            var tempProducts = context.Customers
            .Include(c => c.Orders)
            .ThenInclude(o => o.OrderItems)
            .ToList();
            this.Customers = new ObservableCollection<Customer>(tempProducts);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
