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
        public void printMenu()
        {
            for (int i = 0; i < items.Count; i++)
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
        public override void Run()
        {
            while (true)
            {
                printMenu();
                items[handleUserInput() - 1].Run();
            }
        }
        public int handleUserInput()
        {
            int n;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ввдеите номер пункта: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (n < 0 || n >= items.Count)
                {
                    Console.WriteLine("Введено неверный номер пункта");
                } else
                {
                    break;
                }
            }
            return n;
        }
    }
}