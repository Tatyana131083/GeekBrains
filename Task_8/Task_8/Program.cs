using System;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.Write("Введите имя:");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Имя не введено.");
                    Console.Write($"Нажмите любую кнопку для завершения...");
                    Console.ReadKey();
                    return;

                }
                Properties.Settings.Default.UserName = name;
                Console.Write("Введите возраст:");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Properties.Settings.Default.UserAge = age;
                }
                else
                {
                    Console.WriteLine("Введен некорректный формат возраста.");
                    Console.WriteLine("Возраст не сохранен.");
                }
                Console.Write("Введите род деятельности:");
                Properties.Settings.Default.UserJob = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                string userName = Properties.Settings.Default.UserName;
                int userAge = Properties.Settings.Default.UserAge;
                string userJob = Properties.Settings.Default.UserJob;
                Console.WriteLine($"Имя - {userName}");
                Console.WriteLine($"Возраст - {userAge}");
                Console.WriteLine($"Род деятельности - {userJob}");
            }
            Console.WriteLine();
            Console.Write($"Нажмите любую кнопку для завершения...");
            Console.ReadKey();

        }
    
    }
}
