using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Amir";

            Console.WriteLine($"{name} is {height} metres tall");

            //int length1 = name.Length;
            int length2 = ((string)name).Length;

            Console.WriteLine($"{name} has {length2} characters");

            dynamic anotherName = "Ahmed";
            int length = anotherName.Length;

            Console.WriteLine($"{anotherName} has {length} characters");

            int population = 66_000_000; // 66 million in UK 
            double weight = 1.88; // in kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // strings use double-quotes 
            char letter = 'Z'; // chars use single-quotes
            bool happy = true; // Booleans have value of true or false

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}
