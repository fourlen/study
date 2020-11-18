using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class BriefPrintVisitor : StudentVisitor
    {
        private bool _has_student;
        public void startVisit()
        {
            _has_student = false;
        }
        public void visitStudent(int n, Student student)
        {
            _has_student = true;
            Console.Write($"{n + 1}. ");
            student.printShort();
        }
        public void finishVisit()
        {
            if (!_has_student)
            {
                Console.WriteLine("Студентов нет.");
            }
        }
    }
}
