using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Number1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1...100]: ");
            int num = int.Parse(Console.ReadLine());

            while (num <1||num>100)
                {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [1...100]: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"the number is: {num}");
        }
    }
}
//Напишете програма, която въвежда цяло положително число n в диапазона [1…100]. 
//При въвеждане на число извън посочения 
//диапазон, да се отпечата съобщение за грешка и потребителят да се подкани да въведе ново число.