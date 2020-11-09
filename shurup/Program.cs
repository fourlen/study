using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        public static void StudentsList()
        {
            Console.WriteLine("бебра");
        }
        public static void AddStudent()
        {

        }
        public static void EditStudent()
        {

        }
        public static void RemoveStudent()
        {

        }
        public static void ShowOtlich()
        {

        }
        public static void ShowNeusp()
        {

        }
        public static void Exit()
        {

        }
        public static void ChangeLastName()
        {

        }
        public static void ChangeFirstName()
        {

        }
        public static void ChangeMiddleName()
        {

        }
        public static void ChangeGroup()
        {

        }
        public static void AddMark() 
        {

        }
        public static void ChangeMark()
        {

        }
        public static void RemoveMark()
        {

        }
        public static void Back()
        {

        }
        static void Main(string[] args)
        {
            Menu menu = new Menu("MainMenu");
            menu.AddItem(new SimpleMenuItem("Список студентов", StudentsList));
            menu.AddItem(new SimpleMenuItem("Добавить студента", AddStudent));
            menu.AddItem(new SimpleMenuItem("Редактировать студента", EditStudent));
            menu.AddItem(new SimpleMenuItem("Удалить студента", RemoveStudent));
            menu.AddItem(new SimpleMenuItem("Показать отличников", ShowOtlich));
            menu.AddItem(new SimpleMenuItem("Показать неуспевающих", ShowNeusp));
            menu.AddItem(new SimpleMenuItem("Выход", Exit));
            Menu submenu = new Menu("StudentMenu");
            submenu.AddItem(new SimpleMenuItem("Изменить фамилию", ChangeLastName));
            submenu.AddItem(new SimpleMenuItem("Изменить имя", ChangeFirstName));
            submenu.AddItem(new SimpleMenuItem("Изменить отчество", ChangeMiddleName));
            submenu.AddItem(new SimpleMenuItem("Изменить группу", ChangeGroup));
            submenu.AddItem(new SimpleMenuItem("Добавить оценку", AddMark));
            submenu.AddItem(new SimpleMenuItem("Изменить оценку", ChangeMark));
            submenu.AddItem(new SimpleMenuItem("Удалить оценку", RemoveMark));
            submenu.AddItem(new SimpleMenuItem("Назад", Back));
            while (true)
            {
                menu.Run();
                Console.WriteLine();
                Console.Write("Введите номер пункта: ");
                int nomer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                menu.RunItem(nomer - 1);
            }
        }
    }
}