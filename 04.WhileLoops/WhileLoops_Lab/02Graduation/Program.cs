using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double counter = 1;
            double sum = 0;

            while (counter<=12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade>=4)
                {
                    sum = sum+grade;
                    counter++;
                }
            }
            double average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
        }
    }
}
//Напишете програма, която изчислява средната оценка на ученик от цялото му обучение. 
//На първия ред ще получите името на ученика, а на всеки следващ ред неговите годишни оценки. 
//    Ученикът преминава в следващия клас, ако годишната му оценка е по-голяма или равна на 4.00. 
//Ако оценката му е под 4.00, той ще повтори класа.
//При успешно завършване на 12-ти клас да се отпечата:
// "{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
//Стойността трябва да бъде форматирана до втория знак след десетичната запетая.
//а се подкани да въведе ново число.