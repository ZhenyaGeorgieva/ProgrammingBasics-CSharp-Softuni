using System;
    class Program
    {
        static void Main()
        {
        double trip = double.Parse(Console.ReadLine());
        int puzzle = int.Parse(Console.ReadLine());
        int dolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        double totalToys = puzzle + dolls + bears + minions + trucks;
        double totalSum = 2.6 * puzzle + 3 * dolls + 4.1 * bears + 8.2 * minions + 2 * trucks;

        if (totalToys>=50)
        {
            double finalSum=totalSum*0.75;
            double net = finalSum * 0.9;
            if (net>=trip)
            {
                double rest = net - trip;
                Console.WriteLine("Yes! {0:F2} lv left.",rest);
            }
            else
            {
                double rest = trip - net;
                Console.WriteLine("Not enough money! {0:F2} lv needed.",rest);
            }
        }
        else
        {
            double net = totalSum * 0.9;
            if (net >= trip)
            {
                double rest = net - trip;
                Console.WriteLine("Yes! {0:F2} lv left.",rest);
            }
            else
            {
                double rest = trip - net;
                Console.WriteLine("Not enough money! {0:F2} lv needed.",rest);
            }

        }
    }
}
