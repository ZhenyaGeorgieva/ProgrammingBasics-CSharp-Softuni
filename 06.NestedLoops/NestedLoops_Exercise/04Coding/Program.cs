using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string textNumber = number.ToString();
            int print = 0;
            int print1 = 0;
            print = (number % 10);

            for (int i = textNumber.Length; i >=0; i--)
            {
                
                for (int j = 0; j < print; j++)
                {
                    if (print == 0)
                    {
                        Console.WriteLine("ZERO");
                    }
                    else
                    {
                        print1 = print + 33;
                        char a = (char)print1;
                        Console.Write('a');
                        j++;
                    }
                }
                number = (number - (number % 10)) / 10;
                print = number % 10;


            }
                
            }
          

        }
    }

