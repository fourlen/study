using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class MyList
    {
        private List<int> list = new List<int>();

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public void Add(int elem)
        {
            list.Add(elem);
        }

        public int this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public static MyList operator +(MyList ml1, MyList ml2)
        {
            MyList ml3 = new MyList();
            for (int i = 0; i < ml1.Count; i++)
            {
                ml3.Add(ml1[i]);
            }
            for (int i = 0; i < ml2.Count; i++)
            {
                ml3.Add(ml2[i]);
            }
            return ml3;
        }

        public static MyList operator +(MyList ml, int elem)
        {
            MyList ml2 = new MyList();
            for (int i = 0; i < ml.Count; i++)
            {
                ml2.Add(ml[i]);
            }
            ml2.Add(elem);
            return ml2;
        }

        public static bool Empty(MyList ml)
        {
            return ml.Count == 0;
        }
    }
}
