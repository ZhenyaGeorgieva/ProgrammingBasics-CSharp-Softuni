using System;
    class Program
    {
        static void Main()
        {
        int days = int.Parse(Console.ReadLine());
        int bakers = int.Parse(Console.ReadLine());
        int cakes = int.Parse(Console.ReadLine());
        int gofrets = int.Parse(Console.ReadLine());
        int pancakes = int.Parse(Console.ReadLine());

        double oneBakerSum = cakes * 45 + gofrets * 5.8 + pancakes * 3.2;
        double total = days * oneBakerSum * bakers;
        double net = total -(total/8);
        Console.WriteLine("{0:F2}",net);

    }
    }
