using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел через Enter:");
            //константа для размерности ассива
            const int n = 7;
            int s = 0;
            int k = 0;
            //Массив целых чисел
            int[] array = new int[n];
            //Заполнение массива
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
                k++;
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое чисел равно {0} ", ((double)s) / k);
            Console.ReadKey();
        }  
    }
}
