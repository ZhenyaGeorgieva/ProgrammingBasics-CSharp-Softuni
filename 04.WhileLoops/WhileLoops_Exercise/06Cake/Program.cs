using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());


            int area = width * length;
            bool hasVolume = true;
            string command = Console.ReadLine();
            int pieces = 1;

            while (!(command == "STOP"))
            {
                pieces = int.Parse(command);
                area -= pieces;

                if (area < 0)
                {
                    hasVolume = false;
                    break;
                }
                command = Console.ReadLine();
            }
            if (hasVolume)
                Console.WriteLine($"{area} pieces are left.");
            else
                Console.WriteLine("No more cake left! You need {0} pieces more.",Math.Abs(area));

        }
    }
    }