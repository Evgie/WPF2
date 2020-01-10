using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Employee> employee = new ObservableCollection<Employee>
            {
                new Employee {Id = 1, Name = "Vasya Pupkin", Department = "Sales", HireDate = (new DateTime(2019, 1, 1)).ToString("d"), IsManager = true },
                new Employee {Id = 2, Name = "Petya Ivanov", Department = "Sales", HireDate = (new DateTime(2018, 1, 1)).ToString("d"), IsManager = false},
                new Employee {Id = 3, Name = "Ivan Petrov", Department = "Sales", HireDate = (new DateTime(2017, 1, 1)).ToString("d"), IsManager = false}
            };
            this.DataContext = employee;
        }
    }
}
