using System;

namespace HomeWork_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minTemperature = 0;
            int maxTemperature = 0;
            float avgTemperature;
            Console.WriteLine("Введите минимальную температуру за сутки: ");
            minTemperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки: ");
            maxTemperature = Convert.ToInt32(Console.ReadLine());
            avgTemperature = (minTemperature + maxTemperature) / 2.0f;
            Console.WriteLine($"Средняя температура за сутки равна: {avgTemperature}");
            Console.ReadKey();
            return;
        }
    }
}
