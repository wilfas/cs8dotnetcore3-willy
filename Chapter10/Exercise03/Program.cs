using System;
using Packt.Shared;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography;
using static System.Environment;
using static System.IO.Path;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            var xs = new XmlSerializer(typeof(List<Customer>));
            string path = Combine(CurrentDirectory, "..", "Exercise02", "customersNew.xml");
            List<Customer> loadedCustomers;

            using (FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                // deserialize and cast the object graph into a List of Person 
                loadedCustomers = (List<Customer>)xs.Deserialize(xmlLoad);

                foreach (var item in loadedCustomers)
                {
                    WriteLine($"{item.name} tiene tarjeta {Protector.Decrypt(item.creditcard,"OJETE")}");
                }
            }
        }
    }
}
