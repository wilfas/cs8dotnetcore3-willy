using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mete un número entre 2 y 1000: ");

            int number = int.Parse(ReadLine());
            //int number = 978;
            var calc = new Exercise02Lib.PrimeCalculator();
            WriteLine($"Prime factors of {number} are: {calc.PrimeFactors(number)}");
        }
    }
}
