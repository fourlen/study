using System;
using System.Collections.Generic;
using System.IO;


namespace add
{
    class program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Department depDesign = new Department(random.Next(1,11));
            Department depFront = new Department(random.Next(1, 11));
            Department depBackEnd = new Department(random.Next(1, 11));
            depFront.Subscribe(depDesign);
            depBackEnd.Subscribe(depFront);
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = new Task(random.Next(11), random.Next(11), random.Next(11));
            }
            for (int i = 0; i < tasks.Length; i++)
            {
                depDesign.Update(tasks[i]);
            }
            Console.WriteLine("Отдел дизайна:");
            depDesign.ShowStat();
            Console.WriteLine("Отдел фронт-энда");
            depFront.ShowStat();
            Console.WriteLine("Отдел бэк-энда");
            depBackEnd.ShowStat();
        }
    }
}