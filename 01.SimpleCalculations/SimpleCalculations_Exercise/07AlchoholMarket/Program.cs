using System;

    class Program
    {
        static void Main()
        {
        double whiskyP = double.Parse(Console.ReadLine());
        double beerQ = double.Parse(Console.ReadLine());
        double wineQ = double.Parse(Console.ReadLine());
        double rakiaQ = double.Parse(Console.ReadLine());
        double whiskyQ = double.Parse(Console.ReadLine());

        double rakiaP = whiskyP/2;
        double wineP = rakiaP*0.6;
        double beerP = rakiaP*0.2;

        double rakiaC = rakiaP * rakiaQ;
        double wineC = wineP * wineQ;
        double beerC = beerP * beerQ;
        double whiskyC = whiskyP * whiskyQ;

        double total = rakiaC + wineC + beerC + whiskyC;
        Console.WriteLine($"{total:F2}");
    }
    }

