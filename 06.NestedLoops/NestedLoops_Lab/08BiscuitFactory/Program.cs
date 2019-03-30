using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10BiscuitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchQuantity = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= batchQuantity; i++)
            {
                bool eggs = false;
                bool flour = false;
                bool sugar = false;
                while (true)
                {
                    string command = Console.ReadLine();
                    
                    if (command == "eggs")
                    {
                        eggs = true;
                    }
                    else if (command == "flour")
                    {
                        flour = true;
                    }
                    else if (command == "sugar")
                    {
                        sugar = true;
                    }
                    else if (command == "Bake!")
                    {
                        if (eggs==true && sugar==true && flour == true)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                }
            }
        }
    }
}
