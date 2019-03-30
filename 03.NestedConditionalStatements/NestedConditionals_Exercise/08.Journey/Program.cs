using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if(budget<=100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if(season=="summer")
                {
                    Console.WriteLine($"Camp - {(0.3*budget):f2}");
                    
                }
                else if(season=="winter")
                {
                    Console.WriteLine($"Hotel - {(0.7 * budget):f2}");
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {(0.4 * budget):f2}");

                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Hotel - {(0.8 * budget):f2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {(0.9 * budget):f2}");
            }
        }
    }
}


