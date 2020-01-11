using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Model
{
    public static class Languages
    {
        public static List<string> languagesList;

        static Languages()
        {
            languagesList = new List<string> { "English", "French", "Portuguese" };

        }

        public static string GetLanguage(int number)
        {
            return languagesList[number];
        }
    }
}
