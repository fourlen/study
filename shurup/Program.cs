using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        static void Main(string[] args)
        {
            int kol = 0;
            List<Pupil> pupils = new List<Pupil>();
            for (int i = 0; i < 5; i++)
            {
                Girl girl = new Girl();
                pupils.Add(girl);
                Boy boy = new Boy();
                pupils.Add(boy);
            }
            for (int i = 0; i < pupils.Count; i++)
            {
                int n = pupils[i].DoExercise();
                if (n >= 20)
                {
                    Console.WriteLine(pupils[i].name() + ": " + n + " (" + pupils[i].Type() + ")");
                    kol++;
                }
            }
            Console.WriteLine("Сдавших: " + kol);
        }
    }
}