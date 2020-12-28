using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class BigEmplyee : Employee
    {
        private int chance;
        public Department dep;
        public BigEmplyee(int ch, Department _dep) :
            base(ch)
        {
            dep = _dep;
        }
        public void GiveATask(Task _task)
        {
            for (int i = 0; i < dep.employees.Count; i++)
            {
                if (dep.employees[i].HowLongIsWorking == -1)
                {
                    dep.employees[i].task = _task;
                    return;
                }
            }
            if (HowLongIsWorking == -1)
            {
                task = _task;
                return;
            }
            dep.tasksord.Add(task);
        }
    }
}
