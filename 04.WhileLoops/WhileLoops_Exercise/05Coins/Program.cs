using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeSum = double.Parse(Console.ReadLine());
            int count = 0;
            double coinsTotal = changeSum * 100;

            while (changeSum > 0)
            {
                if (coinsTotal >= 200)
                {
                    coinsTotal -= 200;
                    count++;
                }
                else if (coinsTotal >= 100)
                {
                    coinsTotal -= 100;
                    count++;
                }
                else if (coinsTotal >= 50)
                {
                    coinsTotal -= 50;
                    count++;
                }
                else if (coinsTotal>=20)
                {
                    coinsTotal -= 20;
                    count++;
                }
                else if(coinsTotal>=10)
                {
                    coinsTotal -= 10;
                    count++;
                }
                else if (coinsTotal>=5)
                {
                    coinsTotal -= 5;
                    count++;
                }
                else if (coinsTotal>=2)
                {
                    coinsTotal -= 2;
                    count++;
                }
                else if(coinsTotal>=1)
                {
                    coinsTotal -= 1;
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
