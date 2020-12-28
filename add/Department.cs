using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Department : Subscriber
    {
        public int number;
        private BigEmplyee nachal;
        public List<Employee> employees = new List<Employee>();
        private List<Subscriber> subscribers = new List<Subscriber>();
        public List<Task> tasksord = new List<Task>();
        public void Subscribe(Subscriber sub)
        {
            subscribers.Add(sub);
        }
        public void Notify(Task task)
        {
            for (int i = 0; i < subscribers.Count; i++)
            {
                subscribers[i].Update(task);
            }
        }
        public void Update(Task task)
        {
            nachal.GiveATask(task);
        }
        public void TakeATask(Task task)
        {
            for (int i = 0; i < subscribers.Count; i++)
            {
                if (employees[i].HowLongIsWorking != -1)
                {
                    employees[i].task = task;
                    return;
                }
            }
            if (nachal.HowLongIsWorking != -1)
            {
                nachal.task = task;
                return;
            }
            tasksord.Add(task);
        }
        public void ShowStat()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"Сотрудник {i + 1}: {employees[i].points}");
            }
        }
    }
}