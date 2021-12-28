using System;

namespace HomeWork_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            string monthStr = Console.ReadLine();
            Console.WriteLine();
            try
            {
                int month = Convert.ToInt32(monthStr);
                if(month >=1 && month <= 12)
                {
                    Season season = ConvertFromMonthtoSeason(month);
                    Console.WriteLine(season);
                }
                else
                {
                    PrintWarning();
                }
            }
            catch (Exception)
            {
                PrintWarning();
            }
            
        }

        enum Season
        {
            Winter, 
            Spring, 
            Summer, 
            Autumn,
            Unknown
        }
        static Season ConvertFromMonthtoSeason(int month)
        {
            Season season = Season.Unknown;
            switch (month)
            {               
                case 12:
                case 1:
                case 2: season = Season.Winter; break;
                case 3:
                case 4:
                case 5: season = Season.Spring; break;
                case 6:
                case 7:
                case 8: season = Season.Summer; break;
                case 9:
                case 10:
                case 11: season = Season.Autumn; break;

            }
            return season;
        }
        static void PrintWarning()
        {
            Console.WriteLine("Введите номер месяца от 1 до 12.");
        }
    }
}
