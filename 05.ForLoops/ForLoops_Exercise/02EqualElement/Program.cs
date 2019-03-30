using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EqualElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int max = num;
            int sum = num;
            for (int count = 0; count < n-1; count++)
            {
                int num1 = int.Parse(Console.ReadLine());
                
                if (num1>max)
                {
                    max = num1;
                }
                
                
                    sum += num1;
                
            }
            if((sum-max)==max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs((sum-max)-max)}");
            }
        }
    }
}
 