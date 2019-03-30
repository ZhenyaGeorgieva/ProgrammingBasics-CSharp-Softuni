using System;
    class Program
    {
        static void Main()
        {
        int tables = int.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double areaP = ((2*0.3) + a) * ((2*0.3) + b);
        double areaK = (a / 2) * (a / 2);
        double pricePUSD = 7 * areaP;
        double priceKUSD = 9 * areaK;
        double pricePBGN = 7 * 1.85 * areaP;
        double priceKBGN = 9 * 1.85 * areaK;
        double totalUSD = (tables * pricePUSD)+(tables*priceKUSD);
        double totalBGN = (tables * pricePBGN)+(tables* priceKBGN);
        Console.WriteLine("{0:F2} USD",totalUSD);
        Console.WriteLine("{0:F2} BGN", totalBGN);

    }
    }
//АЛТЕРНАТИВА ЗА ЗАКРЪГЛЯНЕ
//CONSOLE.WRITELINE($"{price:F2} USD");