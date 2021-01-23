using static System.Console;
using Packt.Shared;
using System.Linq;

namespace Exercise02
{
    class Program
    {
        static void CompaniesInCity(string city)
        {
            using (var db = new Northwind())
            {
                var query = db.Customers
                    .Where(customer => customer.City == city)
                    .OrderBy(customer => customer.CompanyName);

                WriteLine($"There are {query.Count()} customers in {city}:");

                foreach (var item in query)
                {
                    WriteLine($"{item.CompanyName}");
                }
            }
        }

        static void Main(string[] args)
        {
            Write("Enter the name of a city: ");
            string city = ReadLine();
            CompaniesInCity(city);

        }
    }
}
