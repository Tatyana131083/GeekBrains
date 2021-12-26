using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "";

            Console.WriteLine($"Введите имя: ");
            user = Console.ReadLine();           
            Console.WriteLine($"Привет, {user}, сегодня {DateTime.Now.ToString("d")}.");
            Console.ReadKey();
            return;
        }
    }
}
