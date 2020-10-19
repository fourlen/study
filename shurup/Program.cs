using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во евро: ");
            int eur = Convert.ToInt32(Console.ReadLine());
            Values euro = new EUR(eur);
            Console.Write("Введите кол-во долларов: ");
            int dollar = Convert.ToInt32(Console.ReadLine());
            Values usd = new USD(dollar);
            Console.Write("Введите кол-во рублей: ");
            int rub = Convert.ToInt32(Console.ReadLine());
            Values rubs = new Rub(rub);
            Console.Write("В какую валюту конвертировать? Евро(1), доллары(2) или рубли(3): ");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                euro.Add(usd);
                euro.Add(rubs);
                Console.WriteLine($"Евро: {euro.GetInThisValue()}");
            } 
            else if (ch == 2)
            {
                usd.Add(euro);
                usd.Add(rubs);
                Console.WriteLine($"{usd.GetInThisValue()}");
            }
            else if (ch == 3)
            {
                rubs.Add(euro);
                rubs.Add(usd);
                Console.WriteLine($"{rubs.GetInThisValue()}");
            }
        }
    }
}