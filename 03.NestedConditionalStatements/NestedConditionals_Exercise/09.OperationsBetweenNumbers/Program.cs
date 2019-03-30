using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Numbers
{
    class Program
    {
        static void Main()
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string operand = Console.ReadLine();
            double result = 0;
           

            switch(operand)
            {
                case "+":
                    result = n1 + n2;
                    if(result%2==0)
                    {
                        Console.WriteLine($"{n1}+{n2}={result}+"-even"");
                    }
                    else
                    {
                        Console.WriteLine($"{n1}+{n2}={result}-"odd"");
                     }break;
                    
                   
                case "-":
                    result = n1 - n2;break;
                    evenorOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{n1}-{n2}={result}-{evenorOdd}");
                case "*":
                    result = n2 * n2;break;
                    evenorOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{n1}*{n2}={result}-{evenorOdd}");
                case "/":
                    result = n1 / n2;
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {n1} by zero");
                    }
                    else
                    Console.WriteLine($"{n1}/{n2}={result:f2}"); break;
                case "%":
                    result = n1 % n2;
                    if (n2==0)
                    {
                        Console.WriteLine("Cannot divide {n1} by zero");
                    }
                    break;


            }
        }
    }
}
