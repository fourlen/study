using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Client : Subscriber
    {
        public Department dep { get; set; }
        public int Complited { get; set; }
        public void Update(Task task)
        {
            Complited++;
            dep.ShowStat();
        }
    }
}