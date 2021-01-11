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
        public Department(int EmployeesCount)
        {
            nachal = new BigEmplyee(EmployeesCount, this);
            Random random = new Random();
            for (int i = 0; i < EmployeesCount; i++)
            {
                Employee empl = new Employee(random.Next(70, 96));
                empl.nachal = nachal;
                employees.Add(empl);
            }
        }
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
            nachal.GiveATask(task);
        }
        public void ShowStat()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"Сотрудник {i + 1}: {employees[i].points}");
            }
        }
        //сделать work, который вызывает work у сатрудников, который должен учесть taskord
        public void Work()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].HowLongIsWorking == -1 && tasksord.Count != 0)
                {
                    employees[i].task = tasksord[0];
                    tasksord.RemoveAt(0);
                }
            }
        }
    }
}