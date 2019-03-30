using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            double balance = 0.0;

            while(counter<n)
            {

               double amount = double.Parse(Console.ReadLine());
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    balance = balance + amount;
                    Console.WriteLine($"Increase: {amount:f2}");
                }
                counter++;
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
//Напишете програма, която пресмята колко общо пари има в сметката, 
//след като направите определен брой вноски. На първия ред ще получите колко вноски трябва да се направят. 
//    На всеки следващ ред ще получавате сумата, която трябва да внесете в сметката, докато не се 
//    достигне броя вноски. При всяка получена сума на конзолата трябва да се извежда "Increase: " + 
//    сумата и тя да се прибавя в сметката. Ако получите число по-малко от 0 на конзолата трябва да се изведе
//    "Invalid operation!" и програмата да приключи. Когато програмата приключи трябва да се принтира "Total: " 
//+ общата сума в сметката закръглена до втория знак след десетичната запетая. 