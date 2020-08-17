using System;

namespace Hello
{
    class Program
    {
        
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
            int min = 0;
            
        }
    }
}