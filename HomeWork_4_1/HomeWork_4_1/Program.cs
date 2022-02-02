using System;

namespace HomeWork_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = GetFullName("Жуков", "Дмитрий", "Александрович");
            Console.WriteLine(name1);
            string name2 = GetFullName("Головина", "Аделина", "Сергеевна");
            Console.WriteLine(name2);
            string name3 = GetFullName("Зубина", "Анна");
            Console.WriteLine(name3);
            string name4 = GetFullName("Фоминов", "Захар", "Дмитриевич");
            Console.WriteLine(name4);
            string name5 = GetFullName("Солоп", "Ирина", "Андреевна");
            Console.WriteLine(name5);

        }
        static string GetFullName(string firstName, string lastName, string patronymic = null)
        {
            if (string.IsNullOrWhiteSpace(patronymic))
            {
                return firstName + " " + lastName;
            } else
            {
                return firstName + " " + lastName + " " + patronymic;
            }
            
        }
    }
}
