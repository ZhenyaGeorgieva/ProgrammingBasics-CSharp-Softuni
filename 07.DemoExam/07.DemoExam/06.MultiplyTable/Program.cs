using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int threeDigitNumber = int.Parse(Console.ReadLine());
            int thirdDigit = threeDigitNumber % 10;
            int twoDigitNumber = threeDigitNumber / 10;
            int secondDigit = twoDigitNumber % 10;
            int firstDigit = twoDigitNumber / 10;

            for (int i = 1; i <= thirdDigit; i++)
            {
                for (int j = 1; j <=secondDigit; j++)
                {
                    for (int z = 1; z <= firstDigit; z++)
                    {
                        if(i>0&&i!=0&&j>0&&j!=0&&z>0&&z!=0)
                        {
                            Console.WriteLine($"{i} * {j} * {z} = {i * j * z};");

                        }
                    }
                }
            }
        }
    }
}
