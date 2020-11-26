using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Introduce un número: ");
            int n = int.Parse(ReadLine());
            Console.WriteLine($"{n} se escribe {n.ToWords()}");
        }
    }
}
