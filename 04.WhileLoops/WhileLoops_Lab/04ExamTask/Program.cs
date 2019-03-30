using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ExamTask
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int maxGoals = 0;
            string bestPlayer = string.Empty;
            

            while (true)
                
            {
                string name = Console.ReadLine();
                if(name=="END")
                {
                    break;
                }
                int goals = int.Parse(Console.ReadLine());
                if (goals>maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = name;
                }
                if (goals>=10)
                {
                    break;
                }
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if(maxGoals>=3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
