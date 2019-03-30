using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08TrainTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juree = int.Parse(Console.ReadLine());
            double sumGrade = 0;
            int counter = 0;
            double totalAverage = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if(command=="Finish")
                {
                    break;
                }
                else
                {
                    sumGrade = 0;
                    string presentation = command;
                    for (int i = 0; i < juree; i++)
                    {
                        double grade = double.Parse(Console.ReadLine());
                        sumGrade += grade;
                    }
                    double averagePerPresentation = sumGrade / juree;
                    Console.WriteLine($"{presentation} - {(averagePerPresentation):f2}.");
                    counter++;
                    totalAverage += averagePerPresentation;
                }
            }
            Console.WriteLine($"Student's final assessment is {(totalAverage/counter):f2}.");
        }
    }
}
