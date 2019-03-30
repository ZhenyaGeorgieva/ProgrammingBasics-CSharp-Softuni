using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03OddEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;
            double oddMax = -1000000000;
            double evenMax = -1000000000;
            double oddMin = 1000000000;
            double evenMin = 1000000000;

            for (int position = 1; position < n+1; position++)
            {
                double number = double.Parse(Console.ReadLine());

                if (position % 2 == 0)
                {
                    evenSum += number;

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else if (position % 2 != 0)
                {
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
            }
                Console.WriteLine($"OddSum={oddSum}");
                if (oddMin == 1000000000)
                {
                    Console.WriteLine("OddMin=No");
                }
                else
                {
                    Console.WriteLine($"OddMin={oddMin}");
                }
                if (oddMax == -1000000000)
                {
                    Console.WriteLine("OddMax=No");
                }
                else
                {
                    Console.WriteLine($"OddMax={oddMax}");
                }
                Console.WriteLine($"EvenSum={evenSum}");
                if (evenMin == 1000000000)
                {
                    Console.WriteLine("EvenMin=No");
                }
                else
                {
                    Console.WriteLine($"EvenMin={evenMin}");
                }
                if (evenMax == -1000000000)
                {
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    Console.WriteLine($"EvenMax={evenMax}");
                }


            }
        }
    }


