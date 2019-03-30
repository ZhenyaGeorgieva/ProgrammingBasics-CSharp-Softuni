using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApart = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApart = 65;
                if (nights >7&&nights<=14)
                {
                    priceStudio = 0.95 * priceStudio;

                }
                else if (nights > 14)
                {
                    priceStudio = 0.7 * priceStudio;
                    priceApart = 0.9 * priceApart;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.2;
                priceApart = 68.7;
                if (nights > 14)
                {
                    priceStudio = 0.8 * priceStudio;
                    priceApart = 0.9 * priceApart;
                }

            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApart = 77;
                if (nights > 14)
                {
                    priceApart = 0.9 * priceApart;
                }
            }

            Console.WriteLine($"Apartment: {(priceApart * nights):f2} lv.");

            Console.WriteLine($"Studio: {(priceStudio * nights):f2} lv.");
        }
    }
}
