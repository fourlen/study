using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Employee
    {
        public int HowLongIsWorking = -1;
        public BigEmplyee nachal { get; set; }
        public Task task { get; set; } = null;
        private int chance;
        public int points { get; set; }
        public Employee(int ch)
        {
            chance = ch;
        }
        public void Work()
        {
            if (task != null)
            {
                HowLongIsWorking += 1;
            }
            if (task != null && nachal != null && HowLongIsWorking > task.times[nachal.dep.number])
            {
                Random random = new Random();
                if (random.Next(0, 100) <= chance)
                {
                    points += 1;
                    nachal.dep.Notify(task);
                    HowLongIsWorking = -1;
                }
                else
                {
                    points -= 1;
                    nachal.points -= 1;
                }
            }
        }
    }
}
