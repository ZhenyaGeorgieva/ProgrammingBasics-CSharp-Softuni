using System;
    class Program
    {
        static void Main()
        {
        int player1 = int.Parse(Console.ReadLine());
        int player2 = int.Parse(Console.ReadLine());
        int player3 = int.Parse(Console.ReadLine());


        if (total < 60)
        {
            if (total < 9)
            {
                Console.WriteLine("0:0{0}", total);
            }
            else
            {
                Console.WriteLine("0:{0}", total);
            }
        }
        else if (total < 120)
        {
            int total1 = total - 60;
            if (total1 < 9)
            {
                Console.WriteLine("1:0{0}", total1);
            }
            else
            {
                Console.WriteLine("1:{0}", total1);
            }
        }
        else if (total < 180)
        {
            int total1 = total - 120;
            if (total1 < 9)
            {
                Console.WriteLine("2:0{0}", total1);
            }
            else
            {
                Console.WriteLine("2:{0}", total1);
            }
        }
    }
    }

