using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int max = number;
            for (int i = 0; i < n-1; i++)
            {

                int number1 = int.Parse(Console.ReadLine());
                if (number1>max)
                {
                    max = number1;
                }

            }
            Console.WriteLine(max);
        }
    }
}
