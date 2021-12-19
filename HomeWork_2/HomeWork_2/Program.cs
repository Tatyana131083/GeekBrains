using System;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minTemperature = 0;
            int maxTemperature = 0;
            float avgTemperature;
            System.Console.WriteLine("Введите минимальную температуру за сутки: ");
            minTemperature = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите максимальную температуру за сутки: ");
            maxTemperature = Convert.ToInt32(Console.ReadLine());
            avgTemperature = (minTemperature + maxTemperature)/2.0f;
            System.Console.WriteLine($"Средняя температура за сутки равна: {avgTemperature}");
            System.Console.ReadKey();
            return;
        }
    }
}
