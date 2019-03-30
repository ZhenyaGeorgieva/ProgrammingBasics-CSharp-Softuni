using System;
    class Program
    {
        static void Main()
        {
        int length = int.Parse(Console.ReadLine());
        int width=int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        int obem = length * width * height;
        double totalL = obem * 0.001;
        double percentI = percent * 0.01;
        double result = totalL * (1 - percentI);
        Console.WriteLine("{0:F3}",result);
        }
}
//1.	Дължина в см – цяло число в интервала [10 … 500]
//2.	Широчина в см – цяло число в интервала[10 … 300]
//3.	Височина в см – цяло число в интервала[10… 200]
//4.	Процент  – реално число в интервала[0.000 … 100.000]

//    //Изчисляваме обем на аквариум:
//обем на аквариум= 85*75*47=299625 см3
//общо литри, които ще събере: 299625 * 0.001=299.625 литра
//процент: 17*0.01=0.17
//литрите, които реално ще трябват : 299.625* (1-0.17) = 248.68875 литра
