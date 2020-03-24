using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Model.Entities
{
    public class Order : INotifyPropertyChanged
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        private string orderStatus;
        public string OrderStatus
        {
            get
            {
                return this.orderStatus;
            }
            set
            {
                if (this.orderStatus == value)
                    return;

                this.orderStatus = value;
                this.OnPropertyChanged(nameof(this.OrderStatus));
            }
        }

        private DateTime orderDate;
        public DateTime OrderDate
        {
            get
            {
                return this.orderDate;
            }
            set
            {
                if (this.orderDate == value)
                    return;

                this.orderDate = value;
                this.OnPropertyChanged(nameof(this.OrderDate));
            }
        }


        private DateTime requiredDate;
        public DateTime RequiredDate
        {
            get
            {
                return this.requiredDate;
            }
            set
            {
                if (this.requiredDate == value)
                    return;

                this.requiredDate = value;
                this.OnPropertyChanged(nameof(this.RequiredDate));
            }
        }

        private DateTime shippedDate;
        public DateTime ShippedDate
        {
            get
            {
                return this.shippedDate;
            }
            set
            {
                if (this.shippedDate == value)
                    return;

                this.shippedDate = value;
                this.OnPropertyChanged(nameof(this.ShippedDate));
            }
        }

        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

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

        private Customer customer;
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if (this.customer == value)
                    return;

                this.customer = value;
                this.OnPropertyChanged(nameof(this.Customer));
            }
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
