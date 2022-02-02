using System;
using System.IO;

namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            File.AppendAllText(filename, DateTime.Now.ToString());    
            File.AppendAllText(filename, Environment.NewLine); 
            string fileText = File.ReadAllText(filename);
            Console.WriteLine(fileText); 

        }
    }
}
