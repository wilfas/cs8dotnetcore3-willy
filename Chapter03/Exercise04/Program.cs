using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Write("Enter a number between 0 and 255: ");
                byte a = byte.Parse(ReadLine());

                Write("Enter another number between 0 and 255: ");
                byte b = byte.Parse(ReadLine());
                WriteLine($"{a} divided by {b} is {a / b}");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }
        }
    }
}
