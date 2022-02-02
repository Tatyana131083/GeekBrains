using System;

namespace HomeWork_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет числа Фибоначчи.");
            Console.Write("Введите номер элемента: ");
            string numberStr = Console.ReadLine();
            if (int.TryParse(numberStr, out int number) && number > 0)
            {
               
                Console.WriteLine("Для элемента под номером {0} число Фибоначчи равно {1:N0}.",
                            arg0: number,
                            arg1: CalcFibonacci(number));
            }
            else
            {
                Console.WriteLine("Значение должно быть целым числом и больше 0!");
            }

        }

        static int CalcFibonacci(int number)
        {
            if (number == 1)
            {
                return 0;
            }
            else if (number == 2)
            {
                return 1;
            }
            else
            {
                return CalcFibonacci(number - 1) + CalcFibonacci(number - 2);
            }
        }
    }
}
