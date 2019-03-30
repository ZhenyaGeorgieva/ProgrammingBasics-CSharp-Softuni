using System;
    class Program
    {
        static void Main(string[] args)
        {
        int grade = int.Parse(Console.ReadLine());
        if (grade%2==0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
        }
    }

