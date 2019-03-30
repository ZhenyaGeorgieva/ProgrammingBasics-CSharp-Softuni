using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string restaurant= Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char delivery = char.Parse(Console.ReadLine());
            double price = 0;
            if (restaurant== "Sushi Zone")
            {
                if(type== "sashimi")
                {
                    price = 4.99;
                }
                    else if(type== "maki")
                {
                    price = 5.29;
                }
                    else if(type== "uramaki")
                {
                    price = 5.99;
                }
                    else if(type== "temaki")
                {
                    price = 4.29;
                }
                double total = portions * price;
                if (delivery == 'Y')
                { total = 1.2 * total; }
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
            else if(restaurant == "Sushi Time")
            {
                if (type == "sashimi")
                {
                    price = 5.49;
                }
                else if (type == "maki")
                {
                    price = 4.69;
                }
                else if (type == "uramaki")
                {
                    price = 4.49;
                }
                else if (type == "temaki")
                {
                    price = 5.19;
                }
                double total = portions * price;
                if (delivery == 'Y')
                { total = 1.2 * total; }
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
            else if(restaurant == "Sushi Bar")
            {
                if (type == "sashimi")
                {
                    price = 5.25;
                }
                else if (type == "maki")
                {
                    price = 5.55;
                }
                else if (type == "uramaki")
                {
                    price = 6.25;
                }
                else if (type == "temaki")
                {
                    price = 4.75;
                }
                double total = portions * price;
                if (delivery == 'Y')
                { total = 1.2 * total; }
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
            else if(restaurant == "Asian Pub")
            {
                if (type == "sashimi")
                {
                    price = 4.50;
                }
                else if (type == "maki")
                {
                    price = 4.80;
                }
                else if (type == "uramaki")
                {
                    price = 5.50;
                }
                else if (type == "temaki")
                {
                    price = 5.50;
                }
                double total = portions * price;
                if (delivery=='Y')
                { total = 1.2 * total; }
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
                
            }
                else
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
            }

        }
    }
}


