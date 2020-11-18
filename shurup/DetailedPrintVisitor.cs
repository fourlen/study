using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class DetailedPrintVisitor : StudentVisitor
    {
        private bool _has_students;
        public void startVisit()
        {
            _has_students = false;
        }
        public void visitStudent(int n, Student student)
        {
            _has_students = true;
            Console.WriteLine($"==={n + 1}===");
            student.printLong();
        }
        public void finishVisit()
        {
            if(!_has_students)
            {
                Console.WriteLine("Студентов нет");
            }
        }
    }
}
