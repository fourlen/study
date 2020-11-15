using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Student
    {
        private static Student insnatce = null;
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string group { get; set; }
        public Dictionary<string, int> marks { get; set; }
        private Student() { }
        public void printLong()
        {
            Console.WriteLine($"Фамилия: {lastname}\n" +
                $"Имя: {firstname}\n" +
                $"Отчество: {middlename}\n" +
                $"Группа: {group}\n" +
                $"Оценки: ");
            subjects();
        }
        public void printShort()
        {
            Console.WriteLine($"{lastname} {firstname} {middlename} ({group})");
        }
        public void subjects()
        {
            foreach (KeyValuePair<string, int> pair in marks)
            {
                Console.WriteLine($"    {pair.Key}: {pair.Value}");
            }
        }
        public static Student GetInstance()
        {
            if (insnatce == null)
            {
                insnatce = new Student();
            }
            return insnatce;
        }
    }
}
