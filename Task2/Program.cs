using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Запрашиваем у пользователя размерность массива
            Console.WriteLine("Введите размерность массива");

            int n = Convert.ToInt32(Console.ReadLine());

            //Массив целых чисел
            int[,] array = new int[n, n];

            //Первый цикл - перебираем строки
            for (int i = 0; i < n; i++)
            {
                //Второй цикл - перебираем столбцы
                for (int j = 0; j < n; j++)
                {
                    //Условие (тернарный оператор)
                    array[i, j] = ((i == j) || (i + j == n - 1) || (i + j) % 2 == 0) ? 1 : 0;
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
