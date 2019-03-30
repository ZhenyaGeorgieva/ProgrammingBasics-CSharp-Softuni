using System;
class Program
{
    static void Main()
    {
        int degrees = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();

        if (partOfDay == "Morning")
        {
            if (10 <= degrees && degrees <= 18)
            {
                string outfit = "Sweatshirt";
                string shoes = "Sneakers";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
            else if (18 < degrees && degrees <= 24)
            {
                string outfit = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
            else if (degrees >= 25)
            {
                string outfit = "T-Shirt";
                string shoes = "Sandals";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
        }
        else if (partOfDay == "Afternoon")
        {
            if (10 <= degrees && degrees <= 18)
            {
                string outfit = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
            else if (18 < degrees && degrees <= 24)
            {
                string outfit = "T-Shirt";
                string shoes = "Sandals";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
            else if (degrees >= 25)
            {
                string outfit = "Swim Suit";
                string shoes = "Barefoot";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
        }
        else if (partOfDay == "Evening")
        {
            if (10 <= degrees && degrees <= 18)
            {
                string outfit = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
            else if (18 < degrees && degrees <= 24)
            {
                string outfit = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
            else if (degrees >= 25)
            {
                string outfit = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            }
        }
        }
    }




