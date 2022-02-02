using System;

namespace HomeWork_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            int index = 0;
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (new Random()).Next(1, 145);
                    Console.Write($"{array[i, j], 5} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Вывод по диагонали:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(index == j)
                    {
                        Console.Write($"{array[i, j],5} ");
                        index++;
                        break;
                    }
                }
            }
        }
    }
}
