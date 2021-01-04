using System;
using Packt.Shared;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography;
using static System.Environment;
using static System.IO.Path;

namespace Exercise02
{
    class Program
    {
        private static string SaltAndHashPassword(string password, string salt)
        {
            var sha = SHA256.Create();
            var saltedPassword = password + salt;
            return Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));
        }

        static void Main(string[] args)
        {
            var xs = new XmlSerializer(typeof(List<Customer>));
            string path = Combine(CurrentDirectory, "customers.xml");
            List<Customer> loadedCustomers;

            using (FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                // deserialize and cast the object graph into a List of Person 
                loadedCustomers = (List<Customer>)xs.Deserialize(xmlLoad);

                foreach (var item in loadedCustomers)
                {
                    item.creditcard = Protector.Encrypt(item.creditcard, "OJETE");
                    item.password = SaltAndHashPassword(item.password, item.name);
                }
            }
            path = Combine(CurrentDirectory, "customersNew.xml");
            using (FileStream stream = File.Create(path))
            {
                // serialize the object graph to the stream 
                xs.Serialize(stream, loadedCustomers);
            }
        }
    }
}
