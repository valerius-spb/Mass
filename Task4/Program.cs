using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив из 15 чисел
            int[] array = new int[15];

            //Генератор случайных чисел
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            int sum = 0;

            for (int i = 1; i < 15; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            sum = min + max;
            Console.WriteLine("Минимальный элемент массива равен {0} ",min);
            Console.WriteLine("Максимальный элемент массива равен {0} ",max);
            Console.WriteLine("Сумма равна {0} ", sum);
            Console.ReadKey();
        }
    }
}
