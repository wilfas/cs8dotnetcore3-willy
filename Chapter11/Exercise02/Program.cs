using static System.Console;
using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Storage;
using System.Xml.Serialization;
using static System.Environment;
using static System.IO.Path;
using System.IO;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Northwind())
            {
                IQueryable<Category> cats = db.Categories.OrderBy(c => c.CategoryName);

                IQueryable<Product> prods = db.Products
                    .OrderBy(product => product.ProductName);

                List<Product> listaProductos = prods.ToList<Product>();
                var xs = new XmlSerializer(typeof(List<Product>));
                string path = Combine(CurrentDirectory, "products.xml");
                using (FileStream stream = File.Create(path))
                {
                    xs.Serialize(stream, listaProductos);
                }

            }
        }
    }
}
