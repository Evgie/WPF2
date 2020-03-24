using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ViewModel.AdminViewModel
{
    public class OrderItemsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<OrderItem> orderItems;
        public ObservableCollection<OrderItem> OrderItems
        {
            get
            {
                return this.orderItems;
            }
            set
            {
                if (this.orderItems == value)
                    return;

                this.orderItems = value;
                this.OnPropertyChanged(nameof(this.OrderItems));
            }
        }

        public OrderItemsViewModel(ObservableCollection<OrderItem> orderItems)
        {
            this.OrderItems = new ObservableCollection<OrderItem>(orderItems);
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
