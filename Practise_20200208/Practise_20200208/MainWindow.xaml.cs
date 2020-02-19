using Practise_20200208.Models;
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

namespace Practise_20200208
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var context = new ZzaContext())
            {
                //var product = context.Product.Find(15);
                //product.Name = "OOO";
                var product = new Product
                {
                    Id = 100,
                    Type = "AHHA",
                    Name = "MyProduct",
                    IsVegetarian = true
                };
                context.Product.Add(product);
                context.SaveChanges();
            }
        }
    }
}
