using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodPerDay = double.Parse(Console.ReadLine());
            double souvenirsPerDay = double.Parse(Console.ReadLine());
            double hotelPerDay = double.Parse(Console.ReadLine());

            double fuelNeeded = (420.0 / 100) * 7.0;
            double moneyFuel = fuelNeeded * 1.85;
            double moneySouvenirsFood = 3 * foodPerDay + 3 * souvenirsPerDay;
            double firstHoteyDay = hotelPerDay * 0.9;
            double secondHotelDay = hotelPerDay * 0.85;
            double thirdHotelDay = hotelPerDay * 0.8;

            double totalMoneyNeeded = moneyFuel + moneySouvenirsFood + firstHoteyDay + secondHotelDay + thirdHotelDay;
            Console.WriteLine($"Money needed: {totalMoneyNeeded:f2}");
        }
    }
}

