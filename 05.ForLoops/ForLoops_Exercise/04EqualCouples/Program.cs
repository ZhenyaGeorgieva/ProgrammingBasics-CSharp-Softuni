﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04EqualCouples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDiff = 0;

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int previousSumValue = num1 + num2;
            for (int i = 0; i < n - 1; i++)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                int currentSumValue = num1 + num2;
                if (previousSumValue != currentSumValue)
                {
                    int tempDiff = Math.Abs(previousSumValue - currentSumValue);
                    if (tempDiff > maxDiff)
                    {
                        maxDiff = tempDiff;
                    }
                    
                }
                previousSumValue = currentSumValue;
            }
            if (maxDiff > 0)
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
            else
            {
                Console.WriteLine($"Yes, value={previousSumValue}");
            }
        }
    }
}
