using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Girl : Pupil
    {
        public override int DoExercise()
        {
            Random random = new Random();
            return random.Next(15, 41);
        }

        public override string name()
        {
            string[] names = { "Надя", "Полина", "Настя", "Виолетта", "Ксюша" };
            Random random = new Random();
            int x = random.Next(0, 5);
            return names[x];
        }
    }
}
