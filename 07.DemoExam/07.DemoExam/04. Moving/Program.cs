using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());


            int volume = width * length * height;
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Done")
                {
                    break;
                }
                else
                {
                    int boxes = int.Parse(command);
                    volume -= boxes;
                    if(volume<=0)
                    {
                        break;
                    }
                }
            }
            if(volume>=0)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}

