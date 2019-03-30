using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            double presents = double.Parse(Console.ReadLine());
            double countA = 0;
            double countB = 0;
            double countV = 0;
            double countG = 0;

            double percentA = 0;
            double percentB = 0;
            double percentV = 0;
            double percentG = 0;
            double percentGuests = 0;


            for (int i = 0; i < presents; i++)
            {
                string category = Console.ReadLine();
                if(category=="A")
                {
                    countA += 1;
                }
                else if (category == "B")
                {
                    countB += 1;
                }
               else if (category == "V")
                {
                    countV += 1;
                }
                if (category == "G")
                {
                    countG += 1;
                }

            }
            percentA = (countA / presents) * 100;
            percentB = (countB / presents) * 100;
            percentV = (countV / presents) * 100;
            percentG = (countG / presents) * 100;
            percentGuests = (presents/guests) * 100;
            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{percentGuests:f2}%");
        }
    }
}
