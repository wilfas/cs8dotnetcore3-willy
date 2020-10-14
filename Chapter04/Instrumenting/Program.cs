using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            Trace.AutoFlush = true;
            
            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");

            var builder = new ConfigurationBuilder()
        }
    }
}
