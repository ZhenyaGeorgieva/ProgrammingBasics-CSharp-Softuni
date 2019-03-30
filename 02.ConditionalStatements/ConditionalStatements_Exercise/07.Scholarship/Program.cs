using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speed
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double social = 0.35 * minSalary;
            double excellent = 25 * grade;

            if (income <= minSalary)
            {
                if (grade >= 5.5)
                {

                    if (excellent >= social)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellent)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
                    }
                }
                else if (grade >= 4.5)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else
            {
                if (grade >= 5.5)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellent)} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
    }
}

