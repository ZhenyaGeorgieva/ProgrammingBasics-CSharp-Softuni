using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09NameWar
{
    class Program
    {
        static void Main(string[] args)
        {
            //            string input = Console.ReadLine();
            //            int maxCombination = int.MinValue;
            //            string winner = string.Empty;
            //            while (input != "STOP")
            //            {
            //                int currentSum = 0;
            //                for (int i = 0; i < input.Length; i++)
            //                {
            //                    currentSum += input[i];
            //                }
            //                if (currentSum >= maxCombination)
            //                {
            //                    maxCombination = currentSum;
            //                    winner = $"Winner is {input} - {maxCombination}!";
            //                }

            //                input = Console.ReadLine();

            //            }
            //            Console.WriteLine(winner);
            //        }
            //    }
            //}


            string name = string.Empty;
            int maxValue = int.MinValue;
            
            while (true)
            {
                int sum = 0;
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    break;
                }
                else
                {
                    name = command;
                    for (int i = 0; i < name.Length; i++)
                    {
                        sum += name[i];

                    }
                    if (sum >= maxValue)
                    {
                        maxValue = sum;
                    }

                }

            }
            Console.WriteLine($"Winner is {name} - {maxValue}!");

        }
    }
}

