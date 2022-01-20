using System;
using System.Diagnostics;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string column1 = "Названия процессов";
                string column2 = "ID процессов";
                Console.Clear();
                Console.WriteLine($"{column1,-40} {column2,10}" + Environment.NewLine);
                foreach (Process proc in Process.GetProcesses())
                {
                    Console.WriteLine($"{proc.ProcessName,-40} {proc.Id,10}");
                }
                Console.WriteLine($"Выберите пункт меню:" + Environment.NewLine);
                Console.WriteLine($"1. - Удалить  процесс по ID");
                Console.WriteLine($"2. - Удалить  процесс по имени");
                Console.WriteLine($"3. - Обновить список процессов");
                Console.WriteLine($"4. - Выйти");
                Console.WriteLine();

                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            Console.Write("Введите ID процесса: ");
                            string userChoice = Console.ReadLine();
                            Console.WriteLine();
                            string message = KillProcessID(userChoice);
                            Console.WriteLine(message);
                            Console.WriteLine();
                            Console.WriteLine("Нажмите любую кнопку для продолжения ...");
                            Console.ReadKey();
                            continue;
                        };
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        {
                            
                            Console.Write("Введите имя процесса: ");
                            string userChoice = Console.ReadLine();
                            Console.WriteLine();
                            string message = KillProcessName(userChoice);
                            Console.WriteLine(message);
                            Console.WriteLine();
                            Console.WriteLine("Нажмите любую кнопку для продолжения ...");
                            Console.ReadKey();
                            continue;
                        };
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3: continue;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4: return;
                }
            }
            
        }

        static string KillProcessID(string id)
        {

            string result = String.Empty;
            try
            {
                Process proc = Process.GetProcessById(int.Parse(id));
                proc.Kill();
                result = $"Процесс завершен!";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }


        static string KillProcessName(string name)
        {

            string result = String.Empty;
            foreach(Process proc in Process.GetProcessesByName(name))
             {
                proc.Kill();
                result += $"Процесс завершен!" + Environment.NewLine;
             }                             
            return result == String.Empty ? "Процесса с таким названием не существует" : result;
        }
    }
}
