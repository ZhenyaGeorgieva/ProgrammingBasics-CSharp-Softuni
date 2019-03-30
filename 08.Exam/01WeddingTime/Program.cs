using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИЗПИТ
{
    class Program
    {
        static void Main(string[] args)
        {
            double whickyP = double.Parse(Console.ReadLine());
            double waterQ = double.Parse(Console.ReadLine());
            double wineQ = double.Parse(Console.ReadLine());
            double champagneQ = double.Parse(Console.ReadLine());
            double whickyQ = double.Parse(Console.ReadLine());

            double champagneP = 0.5 * whickyP;
            double wineP = 0.4 * champagneP;
            double waterP = 0.1 * champagneP;

            double priceWhicky = whickyP * whickyQ;
            double priceWater = waterP * waterQ;
            double priceWine = wineP * wineQ;
            double priceChampagne = champagneP * champagneQ;

            double total = priceWhicky + priceWater + priceWine + priceChampagne;
            Console.WriteLine($"{total:f2}");
        }
    }
}
