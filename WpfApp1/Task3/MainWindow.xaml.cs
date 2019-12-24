using System;
using System.Collections.Generic;
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

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var taskManager = new List<TaskManager>
            {
                new TaskManager {TaskName = "Grocery", Description = "Pick up grocery", Priority = 2},
                new TaskManager {TaskName = "Laundry", Description = "Do my laundry", Priority = 1},
                new TaskManager {TaskName = "Email", Description = "Check mail and reply on urgent", Priority = 3}
            };
            this.DataContext = taskManager;
        }
    }
}
