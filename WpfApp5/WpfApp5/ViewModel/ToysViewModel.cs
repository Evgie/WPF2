using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp5.Model;

namespace WpfApp5.ViewModel
{
    public class ToysViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Toy> toys;

        public ObservableCollection<Toy> Toys
        {
            get
            {
                return this.toys;
            }
            set
            {
                if (this.toys == value)
                    return;

                this.toys = value;
                this.OnPropertyChanged(nameof(this.Toys));
            }
        }

        private Toy selectedToy;

        public Toy SelectedToy
        {
            get
            {
                return this.selectedToy;
            }
            set
            {
                if (this.selectedToy == value)
                    return;

                this.selectedToy = value;
                this.OnPropertyChanged(nameof(this.SelectedToy));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ToysViewModel()
        {
            this.Toys = new ObservableCollection<Toy>
            {
                new Toy{Brand = "Barbie", Model = "Doll", Price = 15.00m, Country = "USA", Age = 7, Type = "Fashion Doll"},
                new Toy{Brand = "LOL", Model = "Doll", Price = 25.00m, Country = "USA", Age = 3, Type = "Fashion Doll"},
                new Toy{Brand = "Trefl", Model = "Puzzle", Price = 10.00m, Country = "Poland", Age = 8, Type = "Game"},
            };
            this.RemoveCommand = new RelayCommand(this.RemoveExecute, this.RemoveCanExecute);
            this.DefaultCommand = new RelayCommand(this.DefaultExecute, this.DefaultCanExecute);
        }

        public ICommand RemoveCommand { get; set; }

        public ICommand DefaultCommand { get; set; }

        public void RemoveExecute(object obj)
        {
            this.Toys.Remove(this.SelectedToy);
        }

        public bool RemoveCanExecute(object obj)
        {
            return !(this.SelectedToy is null);
        }

        public void DefaultExecute(object obj)
        {
            int index = this.Toys.IndexOf(this.SelectedToy);
            this.Toys.RemoveAt(index);
            this.Toys.Insert(index, new Toy { Brand = "MyBrand", Model = "MyModel", Price = 0, Country = "Ukraine", Age = 0, Type = "MyType" });

        }

        public bool DefaultCanExecute(object obj)
        {
            return !(this.SelectedToy is null);
        }
    }
}

