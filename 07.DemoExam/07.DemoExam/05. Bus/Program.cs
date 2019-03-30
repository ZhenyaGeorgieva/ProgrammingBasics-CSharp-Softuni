using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passangers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
            int inward = 0;
            int outward = 0;
            for (int i = 1; i <= stops; i++)
            {
                outward = int.Parse(Console.ReadLine());
                inward = int.Parse(Console.ReadLine());
                passangers -= outward;
                passangers += inward;

                if(i%2!=0)
                {
                    passangers += 2;
                }
                else
                {
                    passangers -= 2;
                }
                
            }
            Console.WriteLine($"The final number of passengers is : { passangers}");
        }
    }
}
