using System;
using static System.Console;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            x = 3;
            y = 2 + ++x;

            x = 3 << 2;
            y = 10 >> 1;

            x = 10 & 8;
            y = 10 | 7;
            
            WriteLine($"x: {x}");
            WriteLine($"y: {y}");
        }
    }
}
