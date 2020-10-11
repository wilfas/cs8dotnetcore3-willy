using System;
using static System.Console;

namespace Exercise3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Pregunta 1
            int a = 3;
            try
            {
                WriteLine(a / 0);
            }
            catch (DivideByZeroException)
            {
                WriteLine("Estás dividiento por cero");
            }

            // Pregunta 2 
            double b = 3;
            // No hay Excepcion!!!
            WriteLine(b / 0);

            // Pregunta 3
            int c = 2147483647;
            c++;
            WriteLine(c);

            //Pregunta 4
            int x = 1;
            int y = 2;
            WriteLine($"x es {x}, y es {y}");
            x = y++;
            WriteLine($"Después de x = y++; x es {x}, y es {y}");

            x = ++y;
            WriteLine($"Después de x = ++y; x es {x}, y es {y}");

            // Pregunta 8 - Bucle infinito
            //for(;true;);


        }
    }
}
