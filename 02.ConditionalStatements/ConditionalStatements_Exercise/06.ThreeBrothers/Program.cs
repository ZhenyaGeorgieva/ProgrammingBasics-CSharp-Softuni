using System;
    class Program
    {
        static void Main()
        {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double D = double.Parse(Console.ReadLine());

        double totalT =1/((1/A)+(1/B)+(1/C));
        double TimeAndRest = 0.15 * totalT+totalT;
        double rest = D - TimeAndRest;
        Console.WriteLine("Cleaning time: {0:F2}", TimeAndRest);

        if (rest>0)
        {
            rest = Math.Floor(D - TimeAndRest);
            Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.",rest);
        }
        else
        {
            rest = Math.Ceiling(TimeAndRest - D);
            Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.",rest);
        }
    }
    }

