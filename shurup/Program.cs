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
            Menu menu = new Menu("MainMenu");
            MenuItem stdlist = new SimpleMenuItem("Список студентов", StudentsList);
            menu.items.Add(stdlist);
            MenuItem stdadd = new SimpleMenuItem("Добавить студента", AddStudent);
            menu.items.Add(stdadd);
            MenuItem stdedit = new SimpleMenuItem("Редактировать студента", EditStudent);
            menu.items.Add(stdedit);
            MenuItem stdremove = new SimpleMenuItem("Удалить студента", RemoveStudent);
            menu.items.Add(stdremove);
            MenuItem stdshowotl = new SimpleMenuItem("Показать отличников", ShowOtlich);
            menu.items.Add(stdshowotl);
            MenuItem stdshowneusp = new SimpleMenuItem("Показать неуспевающих", ShowNeusp);
            menu.items.Add(stdshowneusp);
            MenuItem exit = new SimpleMenuItem("Выход", Exit);
            menu.items.Add(exit);
            Menu submenu = new Menu("StudentMenu");
            MenuItem stdchangelastname = new SimpleMenuItem("Изменить фамилию", ChangeLastName);
            submenu.items.Add(stdchangelastname);
            MenuItem stdchangefirstname = new SimpleMenuItem("Изменить имя", ChangeFirstName);
            submenu.items.Add(stdchangefirstname);
            MenuItem stdchangemiddlename = new SimpleMenuItem("Изменить отчество", ChangeMiddleName);
            submenu.items.Add(stdchangemiddlename);
            MenuItem groupchange = new SimpleMenuItem("Изменить группу", ChangeGroup);
            submenu.items.Add(groupchange);
            MenuItem markadd = new SimpleMenuItem("Добавить оценку", AddMark);
            submenu.items.Add(markadd);
            MenuItem markchange = new SimpleMenuItem("Изменить оценку", ChangeMark);
            submenu.items.Add(markchange);
            MenuItem markremove = new SimpleMenuItem("Удалить оценку", RemoveMark);
            submenu.items.Add(markremove);
            MenuItem back = new SimpleMenuItem("Назад", Back);
            submenu.items.Add(back);
            menu.Run();
        }
    }
}