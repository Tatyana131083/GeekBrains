using System;

namespace HomeWork_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"***Телефонный справочник***");
            string[,] phonebook = { { "КАРЕЗИНА А.П.", "БАБУШКИНА Г.Н.", "ОВЧИННИКОВ А.Л.", "ВИЛКОВ Д.В.", "АКИНИН В.Г."},
                                   { "+7 (831) 2125017", "+7 (831) 2125005", "+7 (831) 2125021", "+7 (831) 2125000", "+7 (831) 2125019" } };
            for(int i = 0; i < phonebook.GetLength(1); i++)
            {
                Console.WriteLine($"{i}.{phonebook[0, i], -16} -  {phonebook[1, i], 15}");
            }
            Console.WriteLine();
            Console.WriteLine($"***Поиск по имени.***");
            Console.Write($"Ведите имя:");
            string name = Console.ReadLine();
            bool isFound = false;
            for (int i = 0; i < phonebook.GetLength(1); i++)
            {
                if (phonebook[0, i] == name.ToUpper())
                {
                    Console.WriteLine($"{phonebook[0, i],-16} -  {phonebook[1, i],15}");
                    isFound = true;
                }               
            }
            if (!isFound)
            {
                Console.WriteLine($"Абонент не найден.");
            }
            Console.ReadKey();
        }
    }
}
