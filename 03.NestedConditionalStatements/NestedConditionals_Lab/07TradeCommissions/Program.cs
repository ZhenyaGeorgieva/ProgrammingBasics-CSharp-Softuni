using System;
    class Program
    {
        static void Main()
        {
        string town = Console.ReadLine();
        double salesQ = double.Parse(Console.ReadLine());
        string town1 = town.ToLower();

        double commission = -1;

        if (town1=="sofia")
        {
            if(salesQ>=0&&salesQ<=500)
            {
                commission = 5;
            }
            else if(salesQ > 500 && salesQ <= 1000)
            {
                commission = 7;
            }
            else if (salesQ > 1000 && salesQ <= 10000)
            {
                commission = 8;
            }
            else if (salesQ > 10000)
            {
                commission = 12;
            }
        }
        else if (town1 == "varna")
        {
            if (salesQ >= 0 && salesQ <= 500)
            {
                commission = 4.5;
            }
            else if (salesQ > 500 && salesQ <= 1000)
            {
                commission = 7.5;
            }
            else if (salesQ > 1000 && salesQ <= 10000)
            {
                commission = 10;
            }
            else if (salesQ > 10000)
            {
                commission = 13;
            }
        }
        else if (town1 == "plovdiv")
        {
            if (salesQ >= 0 && salesQ <= 500)
            {
                commission = 5.5;
            }
            else if (salesQ > 500 && salesQ <= 1000)
            {
                commission = 8;
            }
            else if (salesQ > 1000 && salesQ <= 10000)
            {
                commission = 12;
            }
            else if (salesQ > 10000)
            {
                commission = 14.5;
            }
        }

        if (commission<0)
        {
            Console.WriteLine("error");
        }
        else
        {
            double total = (commission / 100) * salesQ;
            Console.WriteLine($"{total:f2}");
        }
    }
    }

