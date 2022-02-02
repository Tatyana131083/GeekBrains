using System;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Исходный массив:");
            foreach (var value in array)
            {
                Console.WriteLine($"    {value}");
            }
            Console.WriteLine("\nУмножение элементов массива на 2.");
            ModifyArray(array);
            Console.WriteLine("Модифицированный массив: ");
            foreach (var value in array)
            {
                Console.WriteLine($"    {value}");
            }


        }

        static void ModifyArray(int[] array2)
        {
            for(int i = 0; i < array2.Length; i++)
            {
                array2[i] *= 2;
            }
        }
    }
}
