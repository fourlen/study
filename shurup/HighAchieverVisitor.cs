using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class HighAchieverVisitor : StudentVisitor
    {
        private bool _has_students;
        public void startVisit()
        {
            _has_students = false;
        }
        public void visitStudent(int n, Student student)
        {
            bool otlich;
            if (student.marks.Count != 0)
            {
                otlich = true;
            }
            else
            {
                otlich = false;
            }
            foreach (KeyValuePair<string, int> keyvalue in student.marks)
            {
                if (keyvalue.Value != 5)
                {
                    otlich = false;
                    break;
                }
                _has_students = true;
            }
            if (otlich)
            {
                Console.WriteLine($"==={n + 1}===");
                student.printLong();
            }
        }
        public void finishVisit()
        {
            if (!_has_students)
            {
                Console.WriteLine("Отличников нет");
            }
        }
    }
}
