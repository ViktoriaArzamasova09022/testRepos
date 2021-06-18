using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace доп2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n] ;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(0, 10);
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {               
                Console.Write($"{arr[i]}\t");
            }
            int num = 1;
            for(int i = 0; i < n-1; i++)
            {
                if (arr[i] != arr[i + 1]) num++;
            }
            Console.WriteLine($"Количество различных чисел: {num}");

            

            Console.ReadKey();
        }
    }
}
