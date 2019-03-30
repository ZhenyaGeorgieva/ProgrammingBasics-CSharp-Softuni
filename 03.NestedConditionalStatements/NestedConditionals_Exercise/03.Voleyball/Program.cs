using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            if (typeYear=="leap")
            {
                double sofia = 48 - h;
                double satrdaySofiaGames = sofia * (3.0/4);
                double SundayInNativeTown = h;
                double sofia1 = p * (2.0/3);
                double total = satrdaySofiaGames + h + sofia1;
                double totalLeapYear = 1.15 * total;
                Console.WriteLine($"{Math.Floor(totalLeapYear)}");

            }
            else
            {
                double sofia = 48 - h;
                double satrdaySofiaGames = sofia * (3.0 / 4);
                double SundayInNativeTown = h;
                double sofia1 = p * (2.0 / 3);
                double total = satrdaySofiaGames + h + sofia1;
                Console.WriteLine($"{Math.Floor(total)}");
            }
        }
    }
}


