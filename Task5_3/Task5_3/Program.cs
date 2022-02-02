using System;
using System.IO;

namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел от 0 до 255 через пробел.");
            string dataUser = Console.ReadLine();
            string[] dataStr = dataUser.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            byte[] dataByte = new byte[dataStr.Length];
            for(int i = 0; i < dataStr.Length; i++)
            {
                if(byte.TryParse(dataStr[i], out byte result))
                {
                    dataByte[i] = result;
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода {dataStr[i]}. Число должно быть от 0 до 255");
                    return;
                }
                
            }
            File.WriteAllBytes("bytes.bin", dataByte);
            Console.WriteLine("Набор чисел сохранен в файл bytes.bin");
        }
    }
}
