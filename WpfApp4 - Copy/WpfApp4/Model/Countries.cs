using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Model
{
    public static class Countries
    {
        public static List<string> countriesList;

        static Countries()
        {
            countriesList = new List<string> { "USA", "France", "Brazil" };
        }

        public static string GetCountry(int number)
        {
            return countriesList[number];
        }
    }
}
