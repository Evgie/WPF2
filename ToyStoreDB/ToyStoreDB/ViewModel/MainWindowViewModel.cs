using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using ToyStore.DAL.Model;
using ToyStore.DAL.Services;
using ToyStoreDB.ViewModel.Commands;

namespace ToyStoreDB.ViewModel
{
    public class MainWindowViewModel
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

        private GenericRepository<Toy> ToyRepository;

        public MainWindowViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
                return;

            this.ToyRepository = new GenericRepository<Toy>();
            var tempToys = ToyRepository.Get();
            this.Toys = new ObservableCollection<Toy>(tempToys);

            this.RemoveCommand = new RelayCommand(this.RemoveExecute, this.MyCommandsCanExecute);
            this.AddCommand = new RelayCommand(this.AddtExecute);
            this.UpdateCommand = new RelayCommand(this.UpdatetExecute, this.MyCommandsCanExecute);
        }

        public ICommand RemoveCommand { get; set; }

        public ICommand AddCommand { get; set; }

        public ICommand UpdateCommand { get; set; }        

        public void RemoveExecute(object obj)
        {
            this.ToyRepository.Delete(this.SelectedToy);
            this.ToyRepository.Save();
            this.Toys.Remove(this.SelectedToy);
        }

        public bool MyCommandsCanExecute(object obj)
        {
            return !(this.SelectedToy is null);
        }

        public void UpdatetExecute(object obj)
        {
            this.ToyRepository.Update(this.SelectedToy);            
            this.ToyRepository.Save();
        }

        public void AddtExecute(object obj)
        {
            Toy newToy = Toy.GetNewToy();
            this.ToyRepository.Add(newToy);
            this.Toys.Add(newToy);
            this.ToyRepository.Save();
        }
    }
}