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
            Department dep = new Department(random.Next(1,11));
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = new Task(random.Next(11), random.Next(11), random.Next(11));
            }
            for (int i = 0; i < tasks.Length; i++)
            {
                dep.Update(tasks[i]);
            }
            dep.ShowStat();
        }
    }
}