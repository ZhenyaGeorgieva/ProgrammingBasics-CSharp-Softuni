using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationMoneyNeeded = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            string action = string.Empty;
            double transaction = default(double);
            double totalSave = 0;
            double diff = 0;
            int spentCount = 0;
            int daysCount = 0;
            bool saveorSpend = false;
            string result = string.Empty;
            bool isSpend = false;


            while (true)
            {
                action = Console.ReadLine();
                transaction = double.Parse(Console.ReadLine());
                daysCount++;

                if (action == "spend")
                {
                    spentCount++;
                    diff = currentMoney - transaction;
                    currentMoney -= transaction;
                    if (diff < 0)
                    {
                        currentMoney = 0;
                    }
                }
                else if (action == "save")
                {
                    spentCount = 0;
                    currentMoney += transaction;
                }
                if (spentCount == 5)
                {

                    result = $"You can't save the money." +
                    Environment.NewLine + daysCount;
                    isSpend = true;
                    break;
                }

                if (currentMoney >= vacationMoneyNeeded)
                {
                    result = $"You saved the money for {daysCount} days.";
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}

