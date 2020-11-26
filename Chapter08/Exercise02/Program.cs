using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("The default regular expression checks for at least one digit.");

            do
            {
                Write("Enter a regular expression (or press ENTER to use the default): ");
                string regulera = ReadLine();
                if (String.IsNullOrEmpty(regulera))
                {
                    regulera = @"^\d+$";
                }

                Write("Enter some input: ");
                string toCheck = ReadLine();

                var checker = new Regex(regulera);
                WriteLine($"{toCheck} matches {regulera}? {checker.IsMatch(toCheck)}");

                WriteLine("Press ESC to end or any key to try again.");
            }
            while (ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
