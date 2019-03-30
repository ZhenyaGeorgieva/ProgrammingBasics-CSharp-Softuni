using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Rows2K_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter<=n)
            {
                Console.WriteLine(counter);
                counter = (counter * 2) + 1;
            }
        }
    }
}
//8.	Редица числа 2k+1
//Напишете програма, която чете число n, въведено от потребителя,
//    и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, …. 
//    Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.
