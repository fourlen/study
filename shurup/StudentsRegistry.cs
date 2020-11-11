using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class StudentsRegistry
    {
        public List<Student> students { get; set; }
        public StudentsRegistry instance { get; set; }
        public StudentsRegistry() { }
        public StudentsRegistry getInstance()
        {
            return instance;
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
    }
}
