using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp4.Model;

namespace WpfApp4.Tools
{
    public class MyCommands
    {
        public static RoutedCommand Change { get; set; }

        public static RoutedCommand Ok { get; set; }

        public static RoutedCommand Cancel { get; set; }

        static MyCommands()
        {
            MyCommands.Change = new RoutedCommand(nameof(Change), typeof(MainWindow));
            MyCommands.Ok = new RoutedCommand(nameof(Ok), typeof(AuthorWindow));
            MyCommands.Cancel = new RoutedCommand(nameof(Cancel), typeof(AuthorWindow));
        }
    }
}
