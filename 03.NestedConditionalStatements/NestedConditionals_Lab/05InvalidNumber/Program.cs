using System;
    class Program
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        if(!((a>=100&&a<=200)||a==0))
        {
            Console.WriteLine("invalid");
        }
        }
    }
