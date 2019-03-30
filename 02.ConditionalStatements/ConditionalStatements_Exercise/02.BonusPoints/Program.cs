using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double bonusScore = 0;

        if (number <= 100)
        {
            bonusScore += 5;
        }
        else if (number > 100 && number <= 1000)
        {
            bonusScore = number * 0.20;
        }
        else if (number > 1000)
        {
            bonusScore = number * 0.10;
        }

        if (number % 2 == 0)
        {
            bonusScore += 1;
        }
        else if (number % 10 == 5)
        {
            bonusScore += 2;
        }
        Console.WriteLine(bonusScore);
        Console.WriteLine(number + bonusScore);
    }
}

    //    int points = int.Parse(Console.ReadLine());
    //    double bonus = 0.0;
    //    int total = 0;

    //    if (points<=100)
    //    {
    //        if (points%2==0)
    //        {
    //        bonus = 5+1;
    //        }
    //        else if(points%5==0)
    //        {
    //         bonus = 5+2;
    //        }
    //        else
    //        {
    //        bonus = 5;
    //        } 
    //    }
    //    else if (points<1000)
    //    {
    //        if (points % 2 == 0)
    //        {
    //        bonus = (0.2 * points)+1;
    //        }
    //        else if (points % 5 == 0)
    //        {
    //        bonus = (0.2 * points)+2;
    //        }
    //        else
    //        {
    //        bonus = 0.2 * points;
    //        }
    //        }
    //    else
    //    {
    //        if (points % 2 == 0)
    //        {
    //         bonus = (0.1 * points)+1;
    //        }
    //        else if (points % 5 == 0)
    //        {
    //            bonus = (0.1 * points) + 2;
    //        }
    //        else
    //        {
    //        bonus = 0.1 * points;
    //        }
    //    }
    //    Console.WriteLine(bonus);
    //    Console.WriteLine(bonus + points);
    //}
    //}

