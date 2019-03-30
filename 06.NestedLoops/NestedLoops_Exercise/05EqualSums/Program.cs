using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <=b; i++)
            {
                int number = i;
                int sixthDigit = number % 10;
                number = number / 10;
                int fifthDigit = number % 10;
                number = number / 10;
                int fourthDigit = number % 10;
                number = number / 10;
                int thirdDigit = number % 10;
                number = number / 10;
                int secondDigit = number % 10;
                int firstDigit = number / 10;
                if (sixthDigit+fourthDigit+secondDigit==firstDigit+thirdDigit+fifthDigit)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}

