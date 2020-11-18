using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        public static void ListStudentsCommand()
        {
            for (int i = 0; i < StudentsRegistry.GetInstance().getStudentCount(); i++)
            {
                StudentsRegistry.GetInstance().GetStudent(i).printLong();
            }
        }
        public static void AddStudentCommand()
        {
            Console.Write("Введите фамилию: ");
            string name = Console.ReadLine();
            Console.Write("Введите имя: ");
            string lastname = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string middlename = Console.ReadLine();
            Console.Write("Введите группу: ");
            string group = Console.ReadLine();
            Student student = new Student();
            student.firstname = name;
            student.lastname = lastname;
            student.middlename = middlename;
            student.group = group;
            StudentsRegistry.GetInstance().addStudent(student);
            Console.WriteLine();
        }
        public static void EditStudent()
        {

        }
        public static void DeleteStudentCommand()
        {
            for (int i = 0; i < StudentsRegistry.GetInstance().getStudentCount(); i++)
            {
                StudentsRegistry.GetInstance().GetStudent(i).printShort();
            }
            Console.Write("Введите номер: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Вы уверены, что хотите удалить студента {StudentsRegistry.GetInstance().GetStudent(n).lastname} {StudentsRegistry.GetInstance().GetStudent(n).firstname} {StudentsRegistry.GetInstance().GetStudent(n).middlename} ({StudentsRegistry.GetInstance().GetStudent(n).group})?");
            StudentsRegistry.GetInstance().removeStudent(n);
        }
        public static void ShowHighAchieversCommand()
        {
            HighAchieverVisitor hav = new HighAchieverVisitor();
            StudentsRegistry.GetInstance().VisitStudent(hav);
        }
        public static void ShowLowAchieversCommand()
        {
            LowAchieverVisitor hav = new LowAchieverVisitor();
            StudentsRegistry.GetInstance().VisitStudent(hav);
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
            menu.AddItem("Список студентов", ListStudentsCommand);
            menu.AddItem("Добавить студента", AddStudentCommand);
            Menu submenu = menu.AddSubmenu("Редактироват студента");
            menu.AddItem("Удалить студента", DeleteStudentCommand);
            menu.AddItem("Показать отличников", ShowHighAchieversCommand);
            menu.AddItem("Показать неуспевающих", ShowLowAchieversCommand);
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