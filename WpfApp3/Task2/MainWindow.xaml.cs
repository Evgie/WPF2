using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Data;
using System.Globalization;

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
            var window = new InfoWindow();
            window.DataContext = this.dataGridEmployee.SelectedItem;
            window.Show();
        }

        private void NewCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            Employee.GetCount(this.employee);
            this.employee.Add(new Employee { Id = Employee.Count });
        }

        private void NewCommand_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DeleteCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            var selectedItem = this.dataGridEmployee.SelectedItem as Employee;
            this.employee.Remove(selectedItem);
        }

        private void MyCommand_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            if (this.dataGridEmployee.SelectedItem is null)
            {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = true;
        }
    }

    public class MyCommands
    {
        public static RoutedCommand Show { get; set; }

        static MyCommands()
        {
            MyCommands.Show = new RoutedCommand(nameof(Show), typeof(MainWindow));
        }
    }

    public sealed class BooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Convert bool or Nullable bool to Visibility
        /// </summary>
        /// <param name="value">bool or Nullable bool</param>
        /// <param name="targetType">Visibility</param>
        /// <param name="parameter">null</param>
        /// <param name="culture">null</param>
        /// <returns>Visible or Collapsed</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool bValue = false;
            if (value is bool)
            {
                bValue = (bool)value;
            }
            else if (value is Nullable<bool>)
            {
                Nullable<bool> tmp = (Nullable<bool>)value;
                bValue = tmp.HasValue ? tmp.Value : false;
            }
            return (bValue) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
            {
                return (Visibility)value == Visibility.Visible;
            }
            else
            {
                return false;
            }
        }
    }
}
