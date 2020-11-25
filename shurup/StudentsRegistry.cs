using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace shurup
{
    class StudentsRegistry
    {
        private static StudentsRegistry instance = null;
        private List<Student> students = new List<Student>();
        private StudentsRegistry() 
        {
            Load();
        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }
        public void removeStudent(int n)
        {
            students.RemoveAt(n);
        }
        public void removeStudent(Student student)
        {
            students.Remove(student);
        }
        public Student GetStudent(int n)
        {
            return students[n];
        }
        public int getStudentCount()
        {
            return students.Count;
        }
        public static StudentsRegistry GetInstance()
        {
            if (instance == null)
            {
                instance = new StudentsRegistry();
            }
            return instance;
        }
        public void VisitStudent(StudentVisitor visitor)
        {
            visitor.startVisit();
            for (int i = 0; i < students.Count; i++)
            {
                visitor.visitStudent(i, students[i]);
            }
            visitor.finishVisit();
        }
        public void Save()
        {
            FileStream file = new FileStream("C:/Users/obori/OneDrive/Рабочий стол/students.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(file);
            string json = JsonSerializer.Serialize(students);
            sr.Write(json);
            file.Close();
        }
        private void Load()
        {
            FileStream file = new FileStream("C:/Users/obori/OneDrive/Рабочий стол/students.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            string json = sr.ReadToEnd();
            file.Close();
            students = JsonSerializer.Deserialize<List<Student>>(json);
        }
    }
}
