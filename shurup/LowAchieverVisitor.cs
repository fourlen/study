using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class LowAchieverVisitor : StudentVisitor
    {
        private bool _has_students;
        public void startVisit()
        {
            _has_students = false;
        }
        public void visitStudent(int n, Student student)
        {
            _has_students = true;
            bool neusp = false;
            foreach (KeyValuePair<string, int> keyvalue in student.marks)
            {
                if (keyvalue.Value == 2)
                {
                    neusp = true;
                    break;
                }
            }
            if (!neusp)
            {
                Console.WriteLine($"==={n + 1}===");
                student.printLong();
            }
        }
        public void finishVisit()
        {
            if (!_has_students)
            {
                Console.WriteLine("Студентов нет");
            }
        }
    }
}
