using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.IO.Path;
using static System.Environment;
using static System.Console;

/*
using System;                       // DateTime
using System.Threading.Tasks;
using NuJSon = System.Text.Json.JsonSerializer;
*/
namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of Shapes to serialize
            var listOfShapes = new List<Shape>
            {
                new Circle { Colour = "Red", Radius = 2.5},
                new Rectangle {Colour = "Blue", Height = 20.0, Width = 10.0},
                new Circle { Colour = "Green", Radius = 8.0 },
                new Circle { Colour = "Purple", Radius = 12.3 },
                new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
            };

            var xs = new XmlSerializer(typeof(List<Shape>));

            string path = Combine(CurrentDirectory, "shapes.xml");

            using (FileStream stream = File.Create(path))
            {
                xs.Serialize(stream, listOfShapes);
            }

            WriteLine(File.ReadAllText(path));

            WriteLine();
            WriteLine("Loading shapes from XML:");

            using (FileStream fileXml = File.Open(path, FileMode.Open))
            {
                List<Shape> loadedShapesXml = xs.Deserialize(fileXml) as List<Shape>;
                foreach(Shape item in loadedShapesXml)
                {
                    WriteLine("{0} is {1} and has an area of {2:N2}", item.GetType().Name, item.Colour, item.Area);
                }
            }
        }
    }
}
