using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    interface StudentVisitor
    {
        public void startVisit();
        public void visitStudent(int n, Student student);
        public void finishVisit();
    }
}
