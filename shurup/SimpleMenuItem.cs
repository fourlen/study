using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class SimpleMenuItem : MenuItem
    {
        public Action action { get; set; }
        public SimpleMenuItem(string _title, Action _action) :
            base(_title)
        {
            action = _action;
        }
        public override void Run()
        {
            Console.WriteLine(title);
            action();
        }
    }
}
