using System;
using Xunit;
using Exercise02Lib;

namespace Exercise02UnitTests
{
    public class PrimeCalculatorUnitTests
    {
        [Fact]
        public void Test345()
        {
            int a = 345;
            var calc = new PrimeCalculator();

            string resultado = calc.PrimeFactors(a);

            Assert.Equal(resultado, "23 x 5 x 3");
        }
        
        [Fact]
        public void Test1000()
        {
            int a = 1000;
            var calc = new PrimeCalculator();

            string resultado = calc.PrimeFactors(a);

            Assert.Equal(resultado, "5 x 5 x 5 x 2 x 2 x 2");
        }

        [Fact]
        public void Test777()
        {
            int a = 777;
            var calc = new PrimeCalculator();

            string resultado = calc.PrimeFactors(a);

            Assert.Equal(resultado, "37 x 7 x 3");
        }

    }
}
