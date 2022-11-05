using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //НЕ ДОКРУТИЛ НЕМНОГО... МОЖНО НЕ ПРОВЕРЯТЬ!


            //константа для размерности массива
            const int n = 10;

            //Нужен массив из 10 чисел
            int[] array = new int[n];

            //Генератор случайных чисел
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        //временная переменная
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
