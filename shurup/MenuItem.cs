using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    abstract class MenuItem
    {
        public string title { get; set; }
        public abstract void Run();
        public MenuItem(string _title)
        {
            title = _title;
        }
    }
}
