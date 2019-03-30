using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int leftNumbers = int.Parse(Console.ReadLine());
                leftSum += leftNumbers;
            }
            for(int i=1; i<=n; i++)
            {
                int rightNumbers = int.Parse(Console.ReadLine());
                rightSum += rightNumbers;
            }
            if(rightSum==leftSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}

