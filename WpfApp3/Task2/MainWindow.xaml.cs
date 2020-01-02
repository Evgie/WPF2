using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> employee { get; set; }
        public MainWindow()
        {
            InitializeComponent();
           
            employee = new ObservableCollection<Employee>
            {
                new Employee {Id = 1, Name = "Vasya", Department = "Sales", HireDate = new DateTime(2019, 1, 1), IsManager = true },
                new Employee {Id = 2, Name = "Petya", Department = "Sales", HireDate = new DateTime(2018, 1, 1), IsManager = false},
                new Employee {Id = 3, Name = "Ivan", Department = "Sales", HireDate = new DateTime(2017, 1, 1), IsManager = false}
            };
            this.DataContext = employee;
        }

        private void ShowCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {

        }

        private void ShowCommand_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {

        }

        private void NewCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {

        }

        private void NewCommand_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {

        }

        private void DeleteCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            ObservableCollection<Employee> employeeTemp = new ObservableCollection<Employee>();
            
        }

        private void DeleteCommand_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {

        }
    }

    public class CustomCommands
    {
        public static RoutedCommand Show { get; set; }

        static CustomCommands()
        {
            CustomCommands.Show = new RoutedCommand(nameof(Show), typeof(MainWindow));
        }
    }
}
