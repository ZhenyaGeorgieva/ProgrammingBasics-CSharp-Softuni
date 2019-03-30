using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int redove = int.Parse(Console.ReadLine());
            int seatsNechetenRed = int.Parse(Console.ReadLine());
            int seatsCount = 0;

            for (char i = 'A'; i <=sector; i++)
            {
                for (int j = 1; j <= redove; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (char x = 'a'; x < 'a' + seatsNechetenRed + 2; x++)
                        {
                            Console.WriteLine($"{i}{j}{x}");
                            seatsCount++;
                        }
                    }
                    if(j%2!=0)
                        {
                            for (char y = 'a'; y <'a'+seatsNechetenRed; y++)
                             {
                            
                                Console.WriteLine($"{i}{j}{y}");
                                seatsCount++;
                            }   
                        }
                    }
                redove += 1;
            }
            Console.WriteLine(seatsCount);
                
            }
        }
    }


