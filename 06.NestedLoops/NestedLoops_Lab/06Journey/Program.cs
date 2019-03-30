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
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else
                {
                    string destination = command;
                    double budgetNeeded = double.Parse(Console.ReadLine());
                    double currentMoney = 0;
                    while (budgetNeeded > currentMoney)
                    {
                        double savings = double.Parse(Console.ReadLine());
                        currentMoney += savings;
                    }
                    Console.WriteLine($"Going to {destination}!");
                }
            }
        }
    }
}


