using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        static void Main(string[] args)
        {
            MyList ml = new MyList();
            ml.Add(1);
            ml = ml + 2;
            ml.Add(3);
            for (int i = 0; i < ml.Count; i++)
            {
                Console.Write(ml[i] + " ");
            }
            Console.WriteLine();
            MyList ml1 = new MyList();
            ml1.Add(4);
            ml1 = ml1 + 5;
            ml1 = ml1 + 6;
            for (int i = 0; i < ml1.Count; i++)
            {
                Console.Write(ml1[i] + " ");
            }
            Console.WriteLine();
            MyList ml2 = new MyList();
            ml2 = ml + ml1;
            for (int i = 0; i < ml2.Count; i++)
            {
                Console.Write(ml2[i] + " ");
            }
        }
    }
}