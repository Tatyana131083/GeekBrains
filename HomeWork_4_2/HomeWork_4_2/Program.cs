using System;

namespace HomeWork_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите набор чисел, разделенных пробелом");
            string str = Console.ReadLine();
            int result = SumFromStr(str, out bool isCorrect);
            if (isCorrect)
            {
                Console.WriteLine($"Сумма введенных чисел равна: {result}");
            }
            else
            {
                Console.WriteLine($"Введено неверное  число. Число должно быть целым.");
            }
            
        }
        static int SumFromStr(string str, out bool isCorrect)
        {
            int sum = 0;
            isCorrect = true;
            string[] numbers = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var number in numbers)
            {
                if(int.TryParse(number, out int numberInt)){
                    sum += Convert.ToInt32(numberInt);
                } else
                {                   
                    isCorrect = false;
                }
                
            }
            return sum;
        }
    }
}
