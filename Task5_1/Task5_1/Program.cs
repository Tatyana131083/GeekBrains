using System;
using System.IO;

namespace Task5_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор данных.");
            string data = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, data);
            Console.WriteLine("Файл сохранен, нажмите кнопку для выхода.");
            Console.ReadKey();

        }
    }
}
