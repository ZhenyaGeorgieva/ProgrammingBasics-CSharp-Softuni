using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string termDuration = Console.ReadLine();
            string termType = Console.ReadLine();
            string dessert = Console.ReadLine();
            double months = double.Parse(Console.ReadLine());
            double termPrice = 0;

            if(termDuration=="one")
            {
                if(termType== "Small")
                {
                    termPrice = 9.98;
                }
                    if(termType=="Middle")
                {
                    termPrice = 18.99;
                }
                        if(termType=="Large")
                {
                    termPrice = 25.98;
                }
                            if(termType== "ExtraLarge")
                {
                    termPrice = 35.99;
                }
                 if (dessert == "yes" && termPrice > 30)
                {
                    termPrice = termPrice + 3.85;
                }
                else if (dessert == "yes" && termPrice <= 30&&termPrice>10)
                {
                    termPrice = termPrice + 4.35;
                }
                else if (dessert=="yes"&&termPrice<=10)
                {
                    termPrice = termPrice + 5.5;
                }
               
               
            }
                if(termDuration=="two")
            {
                if (termType == "Small")
                {
                    termPrice = 8.58;
                }
                if (termType == "Middle")
                {
                    termPrice = 17.09;
                }
                if (termType == "Large")
                {
                    termPrice = 23.59;
                }
                if (termType == "ExtraLarge")
                {
                    termPrice = 31.79;
                }
                if (dessert == "yes" && termPrice > 30)
                {
                    termPrice = termPrice + 3.85;
                }
                else if (dessert == "yes" && termPrice <= 30 && termPrice > 10)
                {
                    termPrice = termPrice + 4.35;
                }
                else if (dessert == "yes" && termPrice <= 10)
                {
                    termPrice = termPrice + 5.5;
                }
                termPrice = termPrice * ((100-3.75)/100);
            }
            Console.WriteLine($"{(termPrice*months):f2} lv.");
        }
    }
}


