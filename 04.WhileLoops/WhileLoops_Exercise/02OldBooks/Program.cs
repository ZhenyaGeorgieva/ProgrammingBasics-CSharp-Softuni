using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            string command = "";

            while (count<capacity)
            {
                command = Console.ReadLine();
                if (command != bookName)
                {
                    count++;
                }
                else
                {
                    break;
                        }
            }
            if (command==bookName)
            {
                Console.WriteLine($"You checked {count} books and found it.");

            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }

        }
    }
}
