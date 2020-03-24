using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ViewModel.AdminViewModel
{
    public class OrdersListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Order> orders;
        public ObservableCollection<Order> Orders
        {
            get
            {
                return this.orders;
            }
            set
            {
                if (this.orders == value)
                    return;

                this.orders = value;
                this.OnPropertyChanged(nameof(this.Orders));
            }
        }

        private OrderItemsViewModel orderItemsViewModel;
        public OrderItemsViewModel OrderItemsViewModel
        {
            get
            {
                return this.orderItemsViewModel;
            }
            set
            {
                if (this.orderItemsViewModel == value)
                    return;

                this.orderItemsViewModel = value;
                this.OnPropertyChanged(nameof(this.OrderItemsViewModel));
            }
        }

        private Order selectedOrder;
        public Order SelectedOrder
        {
            get
            {
                return this.selectedOrder;
            }
            set
            {
                if (this.selectedOrder == value)
                    return;

                this.selectedOrder = value;
                this.OnPropertyChanged(nameof(this.SelectedOrder));
                this.OrderItemsViewModel = new OrderItemsViewModel(this.SelectedOrder.OrderItems);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public OrdersListViewModel(ObservableCollection<Order> orders)
        {
            this.Orders = new ObservableCollection<Order>(orders); 
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
