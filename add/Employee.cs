using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Employee
    {
        public int HowLongIsWorking = -1;
        public BigEmplyee nachal { get; set; }
        public Task task { get; set; }
        private int chance;
        public int points { get; set; }
        public Employee(int ch)
        {
            chance = ch;
        }
    }
}
