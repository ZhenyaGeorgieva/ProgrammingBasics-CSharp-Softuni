using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <=9 ; j++)
                {
                    for (int x = 1; x <=9 ; x++)
                    {
                        for (int y = 1; y <=9; y++)
                        {
                            if (n % i == 0 && n % j == 0 && n % x == 0&&n%y==0)
                            {
                                Console.Write($"{i}{j}{x}{y} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
