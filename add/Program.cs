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
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0;i<arr.Length;i++)
            {
                arr[i] = random.Next(-100, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 1;i<arr.Length;i++) 
            {
                int x = arr[i];
                int k = i;
                while(k>0 && x<arr[k - 1])
                {
                    arr[k] = arr[k - 1];
                    k--;
                }
                arr[k] = x;
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
            int lol = 10;
        }
    }
}