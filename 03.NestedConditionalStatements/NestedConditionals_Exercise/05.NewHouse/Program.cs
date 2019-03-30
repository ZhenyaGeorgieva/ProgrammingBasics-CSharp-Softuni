using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (flower == "Roses" && quantity > 80)
            {
                price = 0.9 * (quantity * 5);
            }
            else if (flower == "Roses" && quantity <= 80)
            {
                price = (quantity * 5);
            }

            else if (flower == "Dahlias" && quantity > 90)
            {
                price = 0.85 * (quantity * 3.8);
            }
            else if (flower == "Dahlias" && quantity <= 90)
            {
                price = quantity * 3.8;
            }
            else if (flower == "Tulips" && quantity > 80)
            {
                price = 0.85 * (quantity * 2.8);
            }
            else if(flower == "Tulips" && quantity <= 80)
            {
                price = quantity * 2.8;
            }
            else if (flower == "Narcissus" && quantity < 120)
            {
                price = 1.15 * (quantity * 3);
            }
            else if(flower == "Narcissus" && quantity >= 120)
            {
                price = quantity * 3;
            }
            else if (flower == "Gladiolus" && quantity < 80)
            {
                price = 1.2 * (quantity * 2.5);
            }
            else if(flower == "Gladiolus" && quantity >= 80)
            {
                price = quantity * 2.5;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need { (price - budget):f2} leva more.");
            }
        }
    }
}





