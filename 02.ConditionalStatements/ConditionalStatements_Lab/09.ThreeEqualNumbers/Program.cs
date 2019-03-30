using System;
    class Program
    {
        static void Main()
        {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a!=b)
        {
            Console.WriteLine("no");
        }
        else if (b!=c)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine("yes");
        }
    }
    }

//Да се въведат 3 числа и да се отпечата дали са еднакви(yes / no)