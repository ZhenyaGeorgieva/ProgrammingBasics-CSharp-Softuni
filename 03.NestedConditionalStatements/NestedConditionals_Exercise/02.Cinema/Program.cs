using System;
class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        int totalPlaces = rows * columns;

        if (type == "Premiere")
        {
            double totalPrice = totalPlaces * 12;
            Console.WriteLine($"{totalPrice:f2} leva");
        }
        else if (type == "Normal")
        {
            double totalPrice = totalPlaces * 7.5;
            Console.WriteLine($"{totalPrice:f2} leva");
        }
        else if (type == "Discount")
        {
            double totalPrice = totalPlaces * 5;
            Console.WriteLine($"{totalPrice:f2} leva");
        }
    }
}

