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
        public static void DeleteStudentCommand()
        {
            BriefPrintVisitor bpv = new BriefPrintVisitor();
            StudentsRegistry.GetInstance().VisitStudent(bpv);
            Console.Write("Введите номер: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Вы уверены, что хотите удалить студента {StudentsRegistry.GetInstance().GetStudent(n - 1).lastname} {StudentsRegistry.GetInstance().GetStudent(n - 1).firstname} {StudentsRegistry.GetInstance().GetStudent(n - 1).middlename} ({StudentsRegistry.GetInstance().GetStudent(n - 1).group})? [Y/N] ");
            char danet = Convert.ToChar(Console.ReadLine());
            if (danet == 'Y' || danet == 'y')
            {
                StudentsRegistry.GetInstance().removeStudent(n - 1);
            }
            else
            {
                Console.WriteLine("Ладно.");
            }
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
        public static void SelectStudentCommand()
        {
            if (StudentsRegistry.GetInstance().getStudentCount() == 0)
            {
                Console.WriteLine("Список студентов пуст");
                throw new ZeroStudentsException("Список студентов пуст");
            }
            BriefPrintVisitor bpv = new BriefPrintVisitor();
            StudentsRegistry.GetInstance().VisitStudent(bpv);
            int n;
            while (true)
            {
                Console.Write("Введите номер: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 1 && n <= StudentsRegistry.GetInstance().getStudentCount())
                {
                    break;
                } else
                {
                    Console.WriteLine("Студента с таким номером не существует");
                }
            }
            EditContext.GetInstance().student = StudentsRegistry.GetInstance().GetStudent(n);
        }
        public static void ShowSelectedCommand()
        {
            EditContext.GetInstance().student.printLong();
        }
        public static void DeselectStudentCommand()
        {
            EditContext.GetInstance().student = null;
        }
        public static void Exit()
        {

        }
        public static void EditLastNameCommand()
        {
            Console.Write("Введите фамилию: ");
            string lastname = Console.ReadLine();
            EditContext.GetInstance().student.lastname = lastname;
        }
        public static void EditFirstNameCommand()
        {
            Console.Write("Введите имя: ");
            string firstname = Console.ReadLine();
            EditContext.GetInstance().student.firstname = firstname;
        }
        public static void EditMiddleNameCommand()
        {
            Console.Write("Введите отчество: ");
            string middlename = Console.ReadLine();
            EditContext.GetInstance().student.middlename = middlename;
        }
        public static void EditGroupCommand()
        {
            Console.Write("Введите группу: ");
            string group = Console.ReadLine();
            EditContext.GetInstance().student.group = group;
        }
        public static void AddMark() 
        {
            string subj = "";
            while (true)
            {
                Console.Write("Введите предмет: ");
                subj = Console.ReadLine();
                if (EditContext.GetInstance().student.marks.ContainsKey(subj))
                {
                    Console.WriteLine("Оценка по этому предмету уже есть");
                } 
                else
                {
                    break;
                }
            }
            Console.Write("Введите оценку: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            EditContext.GetInstance().student.marks.Add(subj, mark);
        }
        public static void EditMarkCommand()
        {
            if (EditContext.GetInstance().student.marks.Count == 0)
            {
                Console.WriteLine("У студента нет оценок ни по одному предмету");
                throw new NoSubjectsException("У студента нет оценок ни по одному предмету");
            }
            string subj = "";
            while (true)
            {
                Console.Write("Введите предмет: ");
                subj = Console.ReadLine();
                if (!EditContext.GetInstance().student.marks.ContainsKey(subj))
                {
                    Console.WriteLine("Оценки по этому предмету ещё нет");
                }
                else
                {
                    break;
                }
            }
            Console.Write("Введите оценку: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            EditContext.GetInstance().student.marks[subj] = mark;
        }
        public static void DeleteMarkCommand()
        {
            string subj = "";
            while (true)
            {
                Console.Write("Введите предмет: ");
                subj = Console.ReadLine();
                if (!EditContext.GetInstance().student.marks.ContainsKey(subj))
                {
                    Console.WriteLine("Оценки по этому предмету ещё нет");
                }
                else
                {
                    break;
                }
            }
            Console.Write($"Вы уверены, что хотите удалить оценку по предмету {subj}? [Y/N]");
            char danet = Convert.ToChar(Console.ReadLine());
            if (danet == 'Y' || danet == 'y')
            {
                EditContext.GetInstance().student.marks.Remove(subj);
            }
            else
            {
                Console.Write("Ладно");
            }
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
            submenu.AddItem("Изменить фамилию", EditLastNameCommand);
            submenu.AddItem("Изменить имя", EditFirstNameCommand);
            submenu.AddItem("Изменить отчество", EditMiddleNameCommand);
            submenu.AddItem("Изменить группу", EditGroupCommand);
            submenu.AddItem("Добавить оценку", AddMark);
            submenu.AddItem("Изменить оценку", EditMarkCommand);
            submenu.AddItem("Удалить оценку", DeleteMarkCommand);
            menu.Run();
        }
    }
}