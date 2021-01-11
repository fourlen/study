using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Client : Subscriber
    {
        public Department dep { get; set; }
        public int Complited { get; set; } = 0;
        public void Update(Task task)
        {
            if (Complited == 10)
            {
                Complited++;
                dep.ShowStat();
            }
        }
    }
}