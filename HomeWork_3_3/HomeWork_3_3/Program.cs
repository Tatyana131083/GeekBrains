using System;

namespace HomeWork_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string greeting = Console.ReadLine();
            for (int i = greeting.Length-1; i >= 0; i--)
            {
                Console.Write(greeting[i]); // построчный вывод каждого символа строки
            }
            Console.WriteLine("");
        }

    }
}
