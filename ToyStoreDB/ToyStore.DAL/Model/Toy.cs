using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ToyStore.DAL.Model
{
    public class Toy : INotifyPropertyChanged
    {
        public int ToyId { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string brand;

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                if (this.brand == value)
                    return;

                this.brand = value;
                this.OnPropertyChanged(nameof(this.Brand));
            }
        }

        private string model;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (this.model == value)
                    return;

                this.model = value;
                this.OnPropertyChanged(nameof(this.Model));
            }
        }

        private decimal price;

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (this.price == value)
                    return;

                this.price = value;
                this.OnPropertyChanged(nameof(this.Price));
            }
        }

        private string country;

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                if (this.country == value)
                    return;

                this.country = value;
                this.OnPropertyChanged(nameof(this.Country));
            }
        }

        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (this.age == value)
                    return;

                this.age = value;
                this.OnPropertyChanged(nameof(this.Age));
            }
        }

        private string type;

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (this.type == value)
                    return;

                this.type = value;
                this.OnPropertyChanged(nameof(this.Type));
            }
        }

        public static Toy GetNewToy()
        {
            return new Toy { Age = 3, Brand = "WOWToys", Country = "UK", Model = "Tourist Bus", Price = 35.00m, Type = "car" };
        }
    }
}
