using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyP = double.Parse(Console.ReadLine());
            double loveQ = int.Parse(Console.ReadLine());
            double rosesQ = int.Parse(Console.ReadLine());
            double keychainsQ = int.Parse(Console.ReadLine());
            double karikaturiQ = int.Parse(Console.ReadLine());
            double lucksQ = int.Parse(Console.ReadLine());

            double totalQuantity = loveQ + rosesQ + keychainsQ + karikaturiQ + lucksQ;

            double loveP = loveQ * 0.6;
            double rosesP = rosesQ * 7.2;
            double keychainsP = keychainsQ * 3.6;
            double karikaturiP = karikaturiQ * 18.2;
            double lucksP = lucksQ * 22;

            
            double totalP = loveP + rosesP + keychainsP + karikaturiP + lucksP;

            if (totalQuantity >= 25)
            {
                totalP = (0.65 * totalP)*0.9;

            }
            else
            {
                totalP = totalP * 0.9;
            }
           

            if(partyP<=totalP)
            {
                Console.WriteLine($"Yes! {(totalP-partyP):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(partyP-totalP):f2} lv needed.");
            }
        }
    }
}
