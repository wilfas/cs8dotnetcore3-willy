using static System.Console;
using Packt.Shared;
using System.Linq;

namespace Exercise02
{
    class Program
    {
        static void CompaniesInCity()
        {
            using (var db = new Northwind())
            {
                var queryCities = db.Customers
                    .Select(customer => new { City = customer.City })
                    .Distinct()
                    .ToArray();

                int total = queryCities.Count();
                for (int i = 0; i < total ; i++)
                {
                    Write($"{queryCities[i].City}");
                    if (i < total - 1) {
                        Write(", ");
                    }
                }
                WriteLine();

                Write("Enter the name of a city: ");
                string city = ReadLine();

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
            CompaniesInCity();
        }
    }
}
