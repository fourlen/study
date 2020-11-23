using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Menu : MenuItem
    {
        private List<MenuItem> items = new List<MenuItem>();
        private bool main;
        public Action startup_command { get; set; }
        public Action before_select_command { get; set; } 
        public Action tear_down_command { get; set; }
        public Menu():
            base("")
        {
            main = true;
        }
        private Menu(string _title) : 
            base(_title)
        {
            main = false;
        }
        
        private void printMenu()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].title}");
            }
            if (main)
            {
                Console.WriteLine($"{items.Count + 1}. Выход");
            } else
            {
                Console.WriteLine($"{items.Count + 1}. Назад");
            }   
        }
        public void AddItem(string title, Action action)
        {
            MenuItem smenuitem = new SimpleMenuItem(title, action);
            items.Add(smenuitem);
        }
        public override void Run()
        {
            try
            {
                startup_command();
                while (true)
                {
                    before_select_command();
                    printMenu();
                    int n = handleUserInput();
                    if (n == items.Count + 1)
                    {
                        break;
                    }
                    items[n - 1].Run();
                }
                tear_down_command();
            }
            catch (ZeroStudentsException mes)
            {
                Console.WriteLine("Список студентов пуст");
            }
        }
        private int handleUserInput()
        {
            int n;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ввдеите номер пункта: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (n < 0 || n > items.Count + 1)
                {
                    Console.WriteLine("Введено неверный номер пункта");
                } else
                {
                    break;
                }
            }
            return n;
        }
        public Menu AddSubmenu(string title)
        {
            Menu sub_menu = new Menu(title);
            items.Add(sub_menu);
            return sub_menu;
        }
    }
}