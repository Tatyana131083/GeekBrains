using System;

namespace HomeWork_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string shop = "OOO ДВ Невада";
            string adress = "г.Владивосток, ул.Калинина, 8";
            string title = "КАССОВЫЙ ЧЕК № 312";
            int art1 = 1040341;
            int art2 = 1190797;
            int art3 = 3089154;
            string nomeclature1 = "Нектарин КНР";
            string nomeclature2 = "Мюсли 30% фруктов";
            string nomeclature3 = "Творожок Агуша 100";
            float price1 = 315;
            float price2 = 182;
            float price3 = 99;
            float count1 = 0.845f;
            float count2 = 2;
            float count3 = 3;


            Console.WriteLine($"\t\t{shop}");
            Console.WriteLine($"\t{adress}");
            Console.WriteLine();
            Console.WriteLine($"\t\t{title}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"1. {art1} {nomeclature1}       {price1} * {count1}  = {Math.Round(price1*count1, 2)}" );
            Console.WriteLine($"2. {art2} {nomeclature2}  {price2} * {count2}      = {Math.Round(price2 * count2, 2)}");
            Console.WriteLine($"3. {art3} {nomeclature3} {price3}  * {count3}      = {Math.Round(price3 * count3, 2)}");
            Console.WriteLine();
            Console.WriteLine($"\t\t\t  ИТОГО к оплате: {Math.Round(price1 * count1 + price2 * count2 + price3 * count3, 2)}");
        }
    }
}
