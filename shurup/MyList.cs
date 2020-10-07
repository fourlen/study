using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class MyList<T>
    {
        private List<T> list = new List<T>();

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public void Add(T elem)
        {
            list.Add(elem);
        }

        public T this[int index]
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

        public static MyList<T> operator +(MyList<T> ml1, MyList<T> ml2)
        {
            MyList<T> ml3 = new MyList<T>();
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

        public static MyList<T> operator +(MyList<T> ml, T elem)
        {
            MyList<T> ml2 = new MyList<T>();
            for (int i = 0; i < ml.Count; i++)
            {
                ml2.Add(ml[i]);
            }
            ml2.Add(elem);
            return ml2;
        }

        public static bool Empty(MyList<T> ml)
        {
            return ml.Count == 0;
        }
    }
}