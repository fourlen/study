using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        static void Main(string[] args)
        {
            MyList<int> ml = new MyList<int>();
            ml.Add(1);
            ml += 2;
            ml.Add(3);
            for (int i = 0; i < ml.Count; i++)
            {
                Console.Write(ml[i] + " ");
            }
            Console.WriteLine();
            MyList<int> ml1 = new MyList<int>();
            ml1.Add(4);
            ml1 += 5;
            ml1 += 6;
            for (int i = 0; i < ml1.Count; i++)
            {
                Console.Write(ml1[i] + " ");
            }
            Console.WriteLine();
            MyList<int> ml2 = new MyList<int>();
            ml2 = ml + ml1;
            for (int i = 0; i < ml2.Count; i++)
            {
                Console.Write(ml2[i] + " ");
            }
            Console.WriteLine();
            MyList<string> ml3 = new MyList<string>();
            ml3.Add("fgh");
            ml3 += "hjh";
            ml3.Add("iop");
            for (int i = 0; i < ml3.Count; i++)
            {
                Console.Write(ml3[i] + " ");
            }
            Console.WriteLine();
            MyList<string> ml4 = new MyList<string>();
            ml4.Add("asd");
            ml4 += "zxc";
            ml4 += "fgh";
            for (int i = 0; i < ml4.Count; i++)
            {
                Console.Write(ml4[i] + " ");
            }
            Console.WriteLine();
            MyList<string> ml5 = new MyList<string>();
            ml5 = ml3 + ml4;
            for (int i = 0; i < ml5.Count; i++)
            {
                Console.Write(ml5[i] + " ");
            }
        }
    }
}