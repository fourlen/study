using System;
using System.Collections.Generic;
using System.IO;


namespace add
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите часы: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            try
            {
                DateTime dt = new DateTime(year, month, date, hour, minute, second);
                Console.WriteLine($"{dt.Date}.{dt.Month}.{dt.Year} {dt.Hour}:{dt.Minute}:{dt.Second}");
                Console.Write("Введите сдвиг: ");
                int sdvig = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{dt.Date}.{dt.Month}.{dt.Year} {dt.Hour}:{dt.Minute}:{dt.Second}");
            } catch (InvalidTimeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}