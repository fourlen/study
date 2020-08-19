using System;
using System.Collections.Generic;

namespace Hello
{
    class Program
    {
        static void swap(ref int a,ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
        static int findinarr(int number, int[] arr)
        {
            int s = 0;
            int i = 0;
            int e = arr.Length - 1;
            int c = e / 2 + 1;
            while (arr[c] != number)
            {
                i++;
                c = (e + s) / 2;
                if (arr[c] == number)
                {
                    return c;
                } else if (e-s < 1)
                {
                    return -1;
                } else if (number < arr[c])
                {
                    e = c - 1;
                } else if (number > arr[c]) 
                {
                    s = c + 1;
                }
            }
            return c;
        }

        static void findinarrcheck(int number, int[] arr)
        {
            if(findinarr(number, arr) < 0)
            {
                Console.WriteLine("Такого числа в массиве нет.");
            } else
            {
                Console.WriteLine("Номер числа " + number + " в массиве: " + findinarr(number, arr));
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                int k = i;
                while (k > 0 && x < arr[k - 1])
                {
                    arr[k] = arr[k - 1];
                    k--;
                }
                arr[k] = x;
            }
            for(int i = 0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Введите число,которое нужно найти: ");
            int a = Convert.ToInt32(Console.ReadLine());
            /*if (findinarr(a, arr) < 0)
            {
                Console.WriteLine("Такого числа в массиве нет.");
            }
            else
            {
                Console.WriteLine("Номер числа " + a + " в массиве: " + findinarr(a, arr));
            }*/
            findinarrcheck(a, arr);
        }
    }
}