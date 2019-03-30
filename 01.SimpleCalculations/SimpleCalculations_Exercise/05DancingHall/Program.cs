using System;
    class Program
    {
        static void Main()
        {
        double L = double.Parse(Console.ReadLine());
        double W = double.Parse(Console.ReadLine());
        double A = double.Parse(Console.ReadLine())*100;

        double hallArea = (L * 100) * (W * 100);
        double wardrobe = A*A;
        double bench = hallArea / 10;
        double free = hallArea - wardrobe - bench;
        double dancers=free/(40 + 7_000);
        Console.WriteLine(Math.Floor(dancers));   
    }
    }

