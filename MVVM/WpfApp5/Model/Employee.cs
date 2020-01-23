using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public DateTime HireDate { get; set; }

        public bool IsManager { get; set; }

        public static int Count { get; set; }

        public static void GetCount(ObservableCollection<Employee> employee)
        {
            Count = employee.Count;
            Count++;
        }
    }
}
