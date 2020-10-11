﻿using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Write("Fizzbuzz, ");
                    }
                    else
                    {
                        Write("Fizz, ");
                    }
                }
                else if (i % 5 == 0)
                {
                    Write("Buzz, ");
                }
                else {
                    Write($"{i}, ");
                }
            }
        }
    }
}
