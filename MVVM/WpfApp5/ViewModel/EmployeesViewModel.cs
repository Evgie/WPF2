using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp5.Model;
using WpfApp5.ViewModel.Commands;

namespace WpfApp5.ViewModel
{
    public class EmployeesViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Employee> employees;

        public ObservableCollection<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                if (this.employees == value)
                    return;

                this.employees = value;
                this.OnPropertyChanged(nameof(this.Employees));
            }
        }

        public Employee SelectedEmployee { get; set; }

        //public Employee SelectedEmployee
        //{
        //    get
        //    {
        //        return this.selectedEmployee;
        //    }
        //    set
        //    {
        //        if (this.selectedEmployee == value)
        //            return;

        //        this.selectedEmployee = value;
        //        this.OnPropertyChanged(nameof(this.SelectedEmployee));
        //    }
        //}

        public ICommand NewCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public ICommand ShowCommand { get; set; }

        public ICommand ChangeCommand { get; set; }

        public EmployeesViewModel()
        {
            this.Employees = new ObservableCollection<Employee>();
            this.NewCommand = new RelayCommand(this.NewCommandExecute);
            this.DeleteCommand = new RelayCommand(this.DeleteCommandExecute, this.DeleteCommandCanExecute);
            this.ShowCommand = new RelayCommand(this.ShowCommandExecute, this.ShowCommandCanExecute);
            this.ChangeCommand = new RelayCommand(this.ChangeCommandExecute, this.ChangeCommandCanExecute);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
                return;

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NewCommandExecute(object obj)
        {
            Employee.GetCount(this.Employees);
            this.Employees.Add(new Employee { Id = Employee.Count });
        }

        public void DeleteCommandExecute(object obj)
        {
            this.Employees.Remove(this.SelectedEmployee);
        }

        public bool DeleteCommandCanExecute(object obj)
        {
            return this.SelectedEmployee != null;
        }

        public void ShowCommandExecute(object obj)
        {
            this.Employees = new ObservableCollection<Employee>
                {
                new Employee {Id = 1, Name = "Vasya", Department = "Sales", HireDate = new DateTime(2019, 1, 1), IsManager = true },
                new Employee {Id = 2, Name = "Petya", Department = "Sales", HireDate = new DateTime(2018, 1, 1), IsManager = false},
                new Employee {Id = 3, Name = "Ivan", Department = "Sales", HireDate = new DateTime(2017, 1, 1), IsManager = false}
            };
        }

        public bool ShowCommandCanExecute(object obj)
        {
            return !this.Employees.Any();
        }

        public void ChangeCommandExecute(object obj)
        {
            int index = this.Employees.IndexOf(this.SelectedEmployee);
            this.Employees[index] = new Employee { Id = 7, Name = "James Bond", Department = "MI6", HireDate = new DateTime(2019, 1, 1), IsManager = true };
        }

        public bool ChangeCommandCanExecute(object obj)
        {
            return this.SelectedEmployee != null;
        }
    }
}
