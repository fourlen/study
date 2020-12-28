using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Task
    {
        public List<int> times { get; set; } = new List<int>();
        public Task(int dt, int ft, int bt)
        {
            times.Add(dt);
            times.Add(ft);
            times.Add(bt);
        }
    }
}
