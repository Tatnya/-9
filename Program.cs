using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int r;
            int[] mas = new int[n];
            mas[n] = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                mas[i] = rnd.Next(150, 190);
            Console.WriteLine("Выбора школьников, рост каждого из которых < r");
            for (int i = 0; i < n; i++)
                if (mas[i] < r)
                    Console.WriteLine("Исходный массив");
                    Console.ReadKey();
        }
    }
}
