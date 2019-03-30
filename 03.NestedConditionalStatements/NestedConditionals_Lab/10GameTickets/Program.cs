using System;
    class Program
    {
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string kategory = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());
        double price = 0.0;

        if ((people >= 1 && people <= 4) && kategory == "VIP")
        {
            price = 499.99;
            double totalP = price * people;
            double restMoney = 0.25 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }
        }
        else if (people >= 5 && people <= 9 && kategory == "VIP")
        {
            price = 499.99;
            double totalP = price * people;
            double restMoney = 0.4 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }

        }
        else if (people >= 10 && people <= 24 && kategory == "VIP")
        {
            price = 499.99;
            double totalP = price * people;
            double restMoney = 0.5 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }
        }
        else if (people >= 25 && people <= 49 && kategory == "VIP")
        {
            price = 499.99;
            double totalP = price * people;
            double restMoney = 0.6 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }
        }
        else if (people >= 50 && kategory == "VIP")
        {
            price = 499.99;
            double totalP = price * people;
            double restMoney = 0.75 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }
        }

        if ((people >= 1 && people <= 4) && kategory == "Normal")
        {
            price = 249.99;
            double totalP = price * people;
            double restMoney = 0.25 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }
        }
        else if (people >= 5 && people <= 9 && kategory == "Normal")
        {
            price = 249.99;
            double totalP = price * people;
            double restMoney = 0.4 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }

        }
        else if (people >= 10 && people <= 24 && kategory == "Normal")
        {
            price = 249.99;
            double totalP = price * people;
            double restMoney = 0.5 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }
        }
        else if (people >= 25 && people <= 49 && kategory == "Normal")
        {
            price = 249.99;
            double totalP = price * people;
            double restMoney = 0.6 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }
        }
        else if (people >= 50 && kategory == "Normal")
        {
            price = 249.99;
            double totalP = price * people;
            double restMoney = 0.75 * budget;
            if (restMoney >= totalP)
            {
                Console.WriteLine($"Yes! You have {(restMoney - totalP):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalP - restMoney):f2} leva.");
            }
        }
    }
    }
        

 




