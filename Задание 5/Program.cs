using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения: ");
            const int n = 7;
            float sum = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите '{0}' значение массива:  ", i);
                int N = Convert.ToInt32(Console.ReadLine());
                sum +=N;
            }
            float average = sum / n;
            Console.WriteLine("Среднее значение массива: {0:f1}",average);
            Console.ReadKey();
        }
    }
}
