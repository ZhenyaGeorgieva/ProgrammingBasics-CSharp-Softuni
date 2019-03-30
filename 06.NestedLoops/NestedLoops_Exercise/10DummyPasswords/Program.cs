using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13DummyPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <n; i++)
            {
                for (int j = 1; j <n; j++)
                {
                    for (char x = 'a'; x < 'a' + l; x++)
                    {
                        for (char y = 'a'; y <'a'+l; y++)
                        {
                            for (int z = 1; z <=n; z++)
                            {
                                if (z > i && z > j)
                                {
                                    Console.Write($"{ i}{ j}{ x}{ y}{ z} ");
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
