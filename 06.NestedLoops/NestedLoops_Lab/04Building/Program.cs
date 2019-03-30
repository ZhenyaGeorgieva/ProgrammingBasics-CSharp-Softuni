using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
               
                for (int j =0; j<rooms;j++)
                {
                    
                    if (i==floors)
                    {
                       Console.Write($"L{i}{j} ");
                        
                    }
                    else if(floors==1)
                    {
                        Console.Write($"L{i}{j} ");
                        
                        break;
                    }
                    else if (i%2==0)
                    {
                        Console.Write($"O{i}{j} ");
                        
                    }
                    else if(i%2!=0)
                    {
                        Console.Write($"A{i}{j} ");
                        
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}



