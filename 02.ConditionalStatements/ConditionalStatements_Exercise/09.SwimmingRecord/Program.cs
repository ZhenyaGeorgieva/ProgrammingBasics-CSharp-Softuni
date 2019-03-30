using System;
    class Program
    {
    static void Main()
    {
        double record = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double timeInSeconds= double.Parse(Console.ReadLine());

        double totalTime = (distance * timeInSeconds);
        double slowTime = Math.Floor(distance / 15) * 12.5;
        double ivancho = totalTime + slowTime;
        double success = ivancho - record;

        if (ivancho<record)
        {
            Console.WriteLine($" Yes, he succeeded! The new world record is {ivancho:F2} seconds.");
        }
        else
        {

            Console.WriteLine($"No, he failed! He was {Math.Abs(success):F2} seconds slower.");
        }
    }
    }


