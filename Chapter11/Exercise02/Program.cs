using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Xml;
using System.Text.Json;
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
                IQueryable<Category> cats = db.Categories.Include(c => c.Products);

                GenerateXmlFile(cats);
                GenerateCsvFile(cats);
                GenerateJsonFile(cats);

            }
        }

        private static void GenerateXmlFile(IQueryable<Category> cats)
        {
            string path = Combine(CurrentDirectory, "Categories.xml");
            using (FileStream stream = File.Create(path))
            {
                using (XmlWriter xml = XmlWriter.Create(stream, new XmlWriterSettings { Indent = true }))
                {
                    xml.WriteStartDocument();

                    xml.WriteStartElement("categories");
                    foreach (Category c in cats)
                    {
                        xml.WriteStartElement("category");
                        xml.WriteElementString("id", c.CategoryID.ToString());
                        xml.WriteElementString("name", c.CategoryName);
                        xml.WriteElementString("desc", c.Description);
                        xml.WriteElementString("product_count", c.Products.Count.ToString());

                        xml.WriteStartElement("products");
                        foreach (Product p in c.Products)
                        {
                            xml.WriteStartElement("product");
                            xml.WriteElementString("id", p.ProductID.ToString());
                            xml.WriteElementString("name", p.ProductName);
                            xml.WriteElementString("cost", p.Cost.Value.ToString());
                            xml.WriteElementString("stock", p.Stock.ToString());
                            xml.WriteElementString("discontinued", p.Discontinued.ToString());

                            xml.WriteEndElement();
                        }
                        xml.WriteEndElement();

                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                }
            }
        }

        static void GenerateCsvFile(IQueryable<Category> cats)
        {
            string path = Combine(CurrentDirectory, "Categories.csv");
            using (FileStream stream = File.Create(path))
            {
                using (var csv = new StreamWriter(stream))
                {
                    csv.WriteLine("CategoryID,CategoryName,Description,ProductID,ProductName,Cost,Stock,Discontinued");

                    foreach (Category c in cats)
                    {
                        foreach (Product p in c.Products)
                        {
                            csv.Write("{0},\"{1}\",\"{2}\",",
                              arg0: c.CategoryID.ToString(),
                              arg1: c.CategoryName,
                              arg2: c.Description);

                            csv.Write("{0},\"{1}\",{2},",
                              arg0: p.ProductID.ToString(),
                              arg1: p.ProductName,
                              arg2: p.Cost.Value.ToString());

                            csv.WriteLine("{0},{1}",
                              arg0: p.Stock.ToString(),
                              arg1: p.Discontinued.ToString());
                        }
                    }
                }
            }
        }

        static void GenerateJsonFile(IQueryable<Category> cats)
        {
            string path = Combine(CurrentDirectory, "Categories.json");
            using (FileStream stream = File.Create(path))
            {
                using (var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true }))
                {
                    json.WriteStartObject();
                    json.WriteStartArray("categories");
                    foreach (Category c in cats)
                    {
                        json.WriteStartObject();

                        json.WriteNumber("id", c.CategoryID);
                        json.WriteString("name", c.CategoryName);
                        json.WriteString("desc", c.Description);
                        json.WriteNumber("product_count", c.Products.Count);

                        json.WriteStartArray("products");

                        foreach (Product p in c.Products)
                        {
                            json.WriteStartObject();

                            json.WriteNumber("id", p.ProductID);
                            json.WriteString("name", p.ProductName);
                            json.WriteNumber("cost", p.Cost.Value);
                            json.WriteNumber("stock", p.Stock.Value);
                            json.WriteBoolean("discontinued", p.Discontinued);

                            json.WriteEndObject(); // product
                        }
                        json.WriteEndArray(); // products


                        json.WriteEndObject();
                    }
                    json.WriteEndArray();
                    json.WriteEndObject();
                }
            }
        }
    }
}
