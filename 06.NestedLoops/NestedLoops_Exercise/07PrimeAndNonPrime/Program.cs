using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PrimeAndNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                else
                {
                    int number = int.Parse(command);
                    {
                        if (number<0)
                        {
                            Console.WriteLine("Number is negative.");
                        }
                        else 
                        {
                            int divider = 2;

                            int maxDivider = (int)Math.Sqrt(number);

                            bool prime = true;
                            if (number == 1)
                            {
                                prime = false;
                            }
                            else
                            {
                                while (prime && (divider <= maxDivider))

                                {

                                    if (number % divider == 0)

                                    {

                                        prime = false;

                                    }

                                    divider++;

                                }
                            }
                            if (prime==true)
                            {
                                primeSum += number;
                            }
                            else
                            {
                                nonPrimeSum += number;
                            }
                        }
                    }

                }


                }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
            
        }
    }
}


