using System;
    class Program
    {
    static void Main()
    {
        double amount = double.Parse(Console.ReadLine());
        string firstM = Console.ReadLine();
        string secondM = Console.ReadLine();
        double firstRate = 0.0;
        double secondRate = 0.0;

        if (firstM == "m")
        {
            firstRate = 1;
        }
        else if (firstM == "mm")
        {
            firstRate = 1000;
        }
        else if (firstM == "cm")
        {
            firstRate = 100;
        }
        else if (firstM == "mi")
        {
            firstRate = 0.000621371192;
        }
        else if (firstM == "in")
        {
            firstRate = 39.3700787;
        }
        else if (firstM == "km")
        {
            firstRate = 0.001;
        }
        else if (firstM == "ft")
        {
            firstRate = 3.2808399;
        }
        else if (firstM == "yd")
        {
            firstRate = 1.0936133;
        }
        if (secondM == "m")
        {
            secondRate = 1;
        }
        else if (secondM == "mm")
        {
            secondRate = 1000;
        }
        else if (secondM == "cm")
        {
            secondRate = 100;
        }
        else if (secondM == "mi")
        {
            secondRate = 0.000621371192;
        }
        else if (secondM == "in")
        {
            secondRate = 39.3700787;
        }
        else if (secondM == "km")
        {
            secondRate = 0.001;
        }
        else if (secondM == "ft")
        {
            secondRate = 3.2808399;
        }
        else if (secondM == "yd")
        {
            secondRate = 1.0936133;
        }
        double result = amount * (secondRate/ firstRate);
        Console.WriteLine("{0:F8}", result);
    }  
}

