using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Model.Entities
{
    public class Customer : INotifyPropertyChanged
    {
        public int CustomerId { get; set; }

        private string firstName;
        public string FirstName { get; set; }

        private string lastName;
        public string LastName 
        { 
            get
            {
                return this.lastName;
            }
            set
            {
                if (this.lastName == value)
                    return;

                this.lastName = value;
                this.OnPropertyChanged(nameof(this.LastName));
            }
        }

        private string phone;
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (this.phone == value)
                    return;

                this.phone = value;
                this.OnPropertyChanged(nameof(this.Phone));
            }
        }

        private string email;
        public string Email {
            get
            {
                return this.email;
            }
            set
            {
                if (this.email == value)
                    return;

                this.email = value;
                this.OnPropertyChanged(nameof(this.Email));
            }
        }

        private string street;
        public string Street 
        {
            get
            {
                return this.street;
            }
            set
            {
                if (this.street == value)
                    return;

                this.street = value;
                this.OnPropertyChanged(nameof(this.Street));
            }
        }

        private string city;
        public string City 
        {
            get
            {
                return this.city;
            }
            set
            {
                if (this.city == value)
                    return;

                this.city = value;
                this.OnPropertyChanged(nameof(this.City));
            }
        }

        private string state;
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (this.state == value)
                    return;

                this.state = value;
                this.OnPropertyChanged(nameof(this.State));
            }
        }

        private string zipCode;
        public string ZipCode 
        {
            get
            {
                return this.zipCode;
            }
            set
            {
                if (this.zipCode == value)
                    return;

                this.zipCode = value;
                this.OnPropertyChanged(nameof(this.ZipCode));
            }
        }

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
                
        public override string ToString()
        {
            string result = this.FirstName + " " + this.LastName;
            return result.ToString();
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
