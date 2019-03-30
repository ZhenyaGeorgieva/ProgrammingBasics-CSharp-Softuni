using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyQuota = int.Parse(Console.ReadLine());
            int numberOfFish = 0;
            int totalWeightOfFish = 0;
            double pricePerFish = 0;
            double paid = 0;
            double won = 0;
            while (numberOfFish<dailyQuota)
            {
                string command = Console.ReadLine();
                if (command=="Stop")
                {
                    break;
                }
                else
                {
                    string fishName = command;
                    double weightFish = double.Parse(Console.ReadLine());
                    totalWeightOfFish = 0;
                    for (int i = 0; i < fishName.Length; i++)
                    {
                        int ascii = fishName[i];
                        totalWeightOfFish += ascii;
                    }
                    pricePerFish = totalWeightOfFish / weightFish;
                    numberOfFish++;
                    if(numberOfFish%3==0)
                    {
                        won += pricePerFish;
                    }
                    else
                    {
                        paid += pricePerFish;
                    }
                }

            }
            if(numberOfFish==dailyQuota)
            {
                Console.WriteLine($"Lyubo fulfilled the quota!");
            }
            if(won>=paid)
            {
                Console.WriteLine($"Lyubo's profit from {numberOfFish} fishes is {(won-paid):f2} leva.");
            }
            if(won<paid)
            {
                Console.WriteLine($"Lyubo lost {(paid-won):f2} leva today.");
            }
        }
    }
}
