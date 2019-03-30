using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double priceBoat = 0.0;
            
            if (fishers<=6&&season=="Spring")
            {
                priceBoat = 0.9 * 3000;
            }
            else if(fishers<=6&&(season=="Summer"||season=="Autumn"))
            {
                priceBoat = 0.9 * 4200;
            }
            else if(fishers<=6&&season=="Winter")
            {
                priceBoat = 0.9 * 2600;
            }
            else if (fishers <= 11 && season == "Spring")
            {
                priceBoat = 0.85 * 3000;
            }
            else if (fishers <= 11 && (season == "Summer" || season == "Autumn"))
            {
                priceBoat = 0.85 * 4200;
            }
            else if (fishers <=11 && season == "Winter")
            {
                priceBoat = 0.85 * 2600;
            }
            else if (fishers >= 12 && season == "Spring")
            {
                priceBoat = 0.75 * 3000;
            }
            else if (fishers >= 12 && (season == "Summer" || season == "Autumn"))
            {
                priceBoat = 0.75 * 4200;
            }
            else if (fishers >= 12 && season == "Winter")
            {
                priceBoat = 0.75 * 2600;
            }

            if (fishers % 2 == 0&&(season=="Spring"||season=="Summer"||season=="Winter"))
            {
                double total = priceBoat * 0.95;
                if (total<=budget)
                {
                    Console.WriteLine($"Yes! You have {(budget-total):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {(total-budget):f2} leva.");
                }
            }
            else
            {
                if(priceBoat<=budget)
                {
                    Console.WriteLine($"Yes! You have {(budget - priceBoat):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {(priceBoat - budget):f2} leva.");
                }
            }




        }
    }
}
