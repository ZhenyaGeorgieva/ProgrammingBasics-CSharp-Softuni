using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string web = Console.ReadLine();
                if(web=="Facebook")
                {
                    salary -= 150;
                }
                if (web == "Instagram")
                {
                    salary -= 100;
                }
                if (web == "Reddit")
                {
                    salary -= 50;
                }
                if(salary<=0)
                {
                    break;
                }

            }
            if (salary>0)
            {
                Console.WriteLine($"{Math.Round(salary)}");
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
