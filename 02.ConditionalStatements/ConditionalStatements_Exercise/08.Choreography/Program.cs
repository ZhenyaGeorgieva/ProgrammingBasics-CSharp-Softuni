using System;
    class Program
    {
        static void Main()
        {
        double count = double.Parse(Console.ReadLine());
        double dancers = double.Parse(Console.ReadLine());
        double days =double.Parse(Console.ReadLine());
        
        double stepsPerDay =Math.Ceiling(1*100/days);
        
        double stepsForDancer =stepsPerDay / dancers;
        
        if (stepsPerDay<=13)
        {
            Console.WriteLine($"Yes, they will succeed in that goal! {stepsForDancer:F2}%.");
        }
        else
        {
            Console.WriteLine($"No, They will not succeed in that goal! Required {stepsForDancer:F2}% steps to be learned per day.");
        }
    }
    }

