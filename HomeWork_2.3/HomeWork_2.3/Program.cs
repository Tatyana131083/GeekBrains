using System;

namespace HomeWork_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("Число - четное!");
            }
            else
            {
                Console.WriteLine("Число - нечетное!");
            }
            Console.ReadKey();
            return;

        }
    }
}
