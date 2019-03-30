using System;
    class Program
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = a * h / 2;
        Console.WriteLine("{0:F2}", area);
        }
    }

//Напишете програма, която чете от конзолата страна и височина на 
//триъгълник и пресмята неговото лице. Използвайте формулата за лице 
//    на триъгълник: area = a * h / 2. 
//Закръглете резултата до 2 знака след десетичната точка използвайки Math.Round(area, 2).
