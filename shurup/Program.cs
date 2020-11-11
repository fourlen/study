using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        public static void StudentsList()
        {
            
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
            Menu menu = new Menu();
            menu.AddItem("Список студентов", StudentsList);
            menu.AddItem("Добавить студента", AddStudent);
            Menu submenu = menu.AddSubmenu("Редактироват студента");
            menu.AddItem("Удалить студента", RemoveStudent);
            menu.AddItem("Показать отличников", ShowOtlich);
            menu.AddItem("Показать неуспевающих", ShowNeusp);
            submenu.AddItem("Изменить фамилию", ChangeLastName);
            submenu.AddItem("Изменить имя", ChangeFirstName);
            submenu.AddItem("Изменить отчество", ChangeMiddleName);
            submenu.AddItem("Изменить группу", ChangeGroup);
            submenu.AddItem("Добавить оценку", AddMark);
            submenu.AddItem("Изменить оценку", ChangeMark);
            submenu.AddItem("Удалить оценку", RemoveMark);
            menu.Run();
        }
    }
}