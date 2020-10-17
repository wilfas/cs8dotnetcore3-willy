using System;

namespace Exercise02Lib
{
    public class PrimeCalculator
    {
        public string PrimeFactors(int number)
        {
            int[] primos = { 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2 };
            int resto = number;
            string resultado = "";
            int indexPrimos = 0;

            while (resto > 1 && indexPrimos < primos.Length)
            {
                if (resto % primos[indexPrimos] == 0) 
                {
                    resultado = $"{resultado} x {primos[indexPrimos].ToString()}";
                    resto = resto / primos[indexPrimos];
                }
                else 
                {
                    indexPrimos++;
                }
                
            }

            if (resto > 1)
            {
                resultado = $" x {resto}{resultado}";
            }
            
            return resultado.Substring(3, resultado.Length - 3);
        }
    }
}
