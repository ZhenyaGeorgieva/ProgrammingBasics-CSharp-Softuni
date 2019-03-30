using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double Swidth = double. Parse(Console.ReadLine());
            double Slength = double. Parse(Console.ReadLine());
            double Sheight= double. Parse(Console.ReadLine());
            double averageHeight = double. Parse(Console.ReadLine());

            double Svolume = Swidth *Slength * Sheight;
            double roomVolume = 2 * 2 * (0.4 + averageHeight);
            double astronauts= Math.Floor(Svolume / roomVolume);

            if(astronauts>=3&&astronauts<=10)
            {
                Console.WriteLine($"The spacecraft holds {astronauts} astronauts.");
            }
            if(astronauts<3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            if(astronauts>10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}

