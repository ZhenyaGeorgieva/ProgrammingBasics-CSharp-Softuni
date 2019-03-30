using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num%2==0 )
                {
                    p1 += 1;
                }
                if (num%3==0)
                {
                    p2 += 1;
                }
                if (num%4==0)
                {
                    p3 += 1;
                }
            }
            double p1P = p1 / n * 100;
            double p2P = p2 / n * 100;
            double p3P = p3 / n * 100;
         
            Console.WriteLine($"{p1P:f2}%");
            Console.WriteLine($"{p2P:f2}%");
            Console.WriteLine($"{p3P:f2}%");

        }
    }
}
 