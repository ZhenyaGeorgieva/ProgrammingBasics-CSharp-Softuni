using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LeftAndRightPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                int number = i;
                
                int fifthDigit = number % 10;
                number = number / 10;
                int fourthDigit = number % 10;
                number = number / 10;
                int thirdDigit = number % 10;
                number = number / 10;
                int secondDigit = number % 10;
                int firstDigit = number / 10;
                if (fifthDigit + fourthDigit == firstDigit + secondDigit)
                {
                    Console.Write($"{i} ");
                }
                else if (fifthDigit + fourthDigit> firstDigit + secondDigit)
                {

                    if(firstDigit + secondDigit+thirdDigit== fifthDigit + fourthDigit)
                    {
                        Console.Write($"{i} ");
                    }
                }
                else
                {
                    if (firstDigit + secondDigit == fifthDigit + fourthDigit+ thirdDigit)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}



