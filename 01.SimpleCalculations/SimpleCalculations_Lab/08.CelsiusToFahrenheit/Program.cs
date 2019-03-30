using System;
    class Program
    {
        static void Main()
        {
        double celsius = double.Parse(Console.ReadLine());
        double farenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("{0:F2}",farenheit);
        }
    }
//Напишете програма, която чете градуси по скалата на Целзий (°C)
//и ги преобразува до градуси по скалата на Фаренхайт (°F). 
//Потърсете в Интернет подходяща формула, с която да извършите изчисленията. 
//Закръглете резултата до 2 знака след десетичната точка. 
