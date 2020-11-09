﻿using System;
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
            Console.WriteLine();
            Console.Write("Ввдеите номер пункта: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return n;
        }
    }
}