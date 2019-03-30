using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());
            int toysCount = 0;
            double totalMoney = 0;
            double rest = 0;

            for (int count = 1; count <= age; count++)
            {
                if (count % 2 != 0)
                {
                    toysCount += 1;
                }
                else if (count % 2 == 0)
                {
                    totalMoney += ((count * 5)-1);
                    
                }
            }
            double sumToys = priceToy * toysCount;
            double money = totalMoney + sumToys;
            if(priceLaundry<=money)
            {

                Console.WriteLine($"Yes! {(money - priceLaundry):f2}"); 
            }
            else
         {
                Console.WriteLine($"No! {(priceLaundry-money):f2}");
            }
        }
    }
}


