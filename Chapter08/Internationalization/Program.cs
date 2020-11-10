using System.Globalization;
using System;
using static System.Console;

namespace Internationalization
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo globalization = CultureInfo.CurrentCulture;
            CultureInfo localization = CultureInfo.CurrentUICulture;

            WriteLine("The current globalization culture is {0}: {1}", globalization.Name, globalization.DisplayName);
            WriteLine("The current localization culture is {0}: {1}", localization.Name, localization.DisplayName);
            WriteLine();

            WriteLine("en-US: English (United States)");
            


        }
    }
}
