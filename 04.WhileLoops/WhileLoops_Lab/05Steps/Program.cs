using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsSum = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    int finalSteps = int.Parse(Console.ReadLine());
                    stepsSum = finalSteps + stepsSum;
                    break;
                }
                else
                {
                    int current = int.Parse(command);
                    stepsSum = stepsSum + current;
                    if (stepsSum >= 10000)
                    {
                        break;
                    }
                }
            }
            if (stepsSum >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{(10000 - stepsSum)} more steps to reach goal.");
            }
        }
    }
}
//Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден. 
//Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си. 
//    Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза 
//    през деня и когато постигне целта си да се изписва "Goal reached! Good job!"  
//Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, 
//    които е извървяла докато се прибира.След което, ако не е успяла да постигне целта си, на 
//    конзолата трябва да се изпише: "{разликата между стъпките} more steps to reach goal."
