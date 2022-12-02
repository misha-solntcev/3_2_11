using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 11. Найти все целые числа из промежутка от 100 до 300, 
    у которых сумма делителей равна 50. */

namespace _3_2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 300; i++)
            {
                int sum = 0;
                for (int j = 1; j < 300; j++)
                {
                    if (i % j == 0)
                    {
                        Console.WriteLine($"\t j={j}");
                        sum += j;
                    }
                }                
                Console.WriteLine($"i={i}, sum={sum}");                                
            }
            Console.ReadKey();
        }
    }
}
