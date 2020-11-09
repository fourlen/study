using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Menu : MenuItem
    {
        private List<MenuItem> items = new List<MenuItem>();
        public Menu(string _title) :
            base(_title)
        { }
        public override void Run()
        {
            for(int i = 0; i < items.Count; i++)
            {
                Console.Write($"{i + 1}. {items[i].title}");
                Console.WriteLine();
            }
        }
        public void AddItem(MenuItem menuitem)
        {
            items.Add(menuitem);
        }
        public void RunItem(int n)
        {
            items[n].Run();
        }
    }
}