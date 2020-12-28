using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Task
    {
        public double DesignTime { get; set; }
        public double FrontTime { get; set; }
        public double BackTime { get; set; }
        public Task(int dt, int ft, int bt)
        {
            DesignTime = dt;
            FrontTime = ft;
            BackTime = bt;
        }
    }
}
