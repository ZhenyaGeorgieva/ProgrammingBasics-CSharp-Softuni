using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int baloonsCounter = 0;
            int flowersCounter = 0;
            int candlesCounter = 0;
            int ribbonCounter = 0;
            string command = " ";
            double spent = 0;

            while (budget>0)
            {
                command = Console.ReadLine();
                if(command=="stop")
                {
                    break;
                }
                else
                {
                    string article = command;
                    int quantity = int.Parse(Console.ReadLine());
                    double articleTotal = 0;
                    if (article== "balloons")
                    {
                        baloonsCounter += quantity;
                        articleTotal = quantity * 0.1;
                        budget -= articleTotal;
                        spent += articleTotal;
                    }
                    if(article== "flowers")
                    {
                        flowersCounter += quantity;
                        articleTotal = quantity * 1.5;
                        budget -= articleTotal;
                        spent += articleTotal;
                    }
                    if(article== "candles")
                    {
                        candlesCounter += quantity;
                        articleTotal = quantity * 0.5;
                        budget -= articleTotal;
                        spent += articleTotal;
                    }
                    if(article== "ribbon")
                    {
                        ribbonCounter += quantity;
                        articleTotal = quantity * 2;
                        budget -= articleTotal;
                        spent += articleTotal;

                    }
                }
            }
            
            if(command=="stop")
            {
                Console.WriteLine($"Spend money: {spent:f2}");
                Console.WriteLine($"Money left: { budget:f2}");
            }
            if(budget<=0)
            {
                Console.WriteLine("All money is spent!");
            }
            Console.WriteLine($"Purchased decoration is {baloonsCounter} balloons, {ribbonCounter} m ribbon, {flowersCounter} flowers and {candlesCounter} candles.");
        }
    }
}


