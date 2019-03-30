using System;
    class Program
    {
        static void Main()
        {
        double rad = double.Parse(Console.ReadLine());
        double deg = rad * (180.0 / Math.PI);
        Console.WriteLine(Math.Round(deg));
        }
}

////Напишете програма, която чете ъгъл в радиани (rad) и го преобразува в градуси (deg). 
//Потърсете в Интернет подходяща формула. Числото π в C# програми е достъпно чрез Math.PI. 
//Закръглете резултата до най-близкото цяло число използвайки Math.Round(). 
//angle * (180.0 / Math.PI);

