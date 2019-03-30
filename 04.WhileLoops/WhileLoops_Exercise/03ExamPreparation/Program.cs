using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int BadGrades = int.Parse(Console.ReadLine());
            int counterOfBadGrades = 0;
            int count = 0;
            double total = 0;
            string last = string.Empty;
            while (true)

            {
                string nameOfExercise = Console.ReadLine();
                if (nameOfExercise == "Enough")
                {
                    double average = total / count;

                    Console.WriteLine($"Average score: {average:f2}");
                    Console.WriteLine($"Number of problems: {count}");
                    Console.WriteLine($"Last problem: {last}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    counterOfBadGrades++;
                }
                if (counterOfBadGrades == BadGrades)
                {
                    Console.WriteLine("You need a break, {0} poor grades.", counterOfBadGrades);
                    break;
                }
                last = nameOfExercise;
                total += grade;
                count++;
            }
        }
    }
}
                

                
