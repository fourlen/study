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
            Client client = new Client();
            depFront.Subscribe(depDesign);
            depBackEnd.Subscribe(depFront);
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = new Task(random.Next(11), random.Next(11), random.Next(11));
            }
            for (int i = 0; i < tasks.Length; i++)
            {
                if (i < tasks.Length)
                {
                    depDesign.Update(tasks[i]);
                }
                depDesign.Work();
                depFront.Work();
                depBackEnd.Work();
                Console.WriteLine(depDesign.tasksord.Count);
            }
            Console.WriteLine("Отдел дизайна:");
            depDesign.ShowStat();
            Console.WriteLine("Отдел фронт-энда");
            depFront.ShowStat();
            Console.WriteLine("Отдел бэк-энда");
            depBackEnd.ShowStat();
            //почему-то такс не доходит до сотрудника
        }
    }
}