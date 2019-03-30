using System;
    class Program
    {
        static void Main()
        {
        decimal amount = decimal.Parse(Console.ReadLine());
        string firstCurrency = Console.ReadLine();
        string secondCurrency = Console.ReadLine();
        decimal firstRate = 0.0m;
        decimal secondRate = 0.0m;
        if (firstCurrency == "BGN")
        {
            firstRate = 1m;
        }
        else if(firstCurrency=="USD")
        {
            firstRate = 1.79549m;
        }
        else if(firstCurrency=="EUR")
        {
            firstRate = 1.95583m;
        }
        else if(firstCurrency=="GBP")
        {
            firstRate = 2.53405m;
        }
        if (secondCurrency == "BGN")
        {
            secondRate = 1m;
        }
        else if (secondCurrency == "USD")
        {
            secondRate = 1.79549m;
        }
        else if (secondCurrency=="EUR")
        {
            secondRate = 1.95583m;
        }
        else if(secondCurrency=="GBP")
        {
            secondRate = 2.53405m;
        }
        decimal result = amount * (firstRate / secondRate);
        Console.WriteLine("{0:F2}",result);
        }
    }

//Console.WriteLine(($"{result:F2}{secondCurrency}");

    ////3.	Конзолен междувалутен конвертор*
//Напишете програма за конвертиране на парична сума от една валута в друга.
//    Трябва да се поддържат следните валути: BGN, USD, EUR, GBP.
//    Използвайте следните фиксирани валутни курсове:
//Курс USD EUR GBP
//1 BGN   1.79549	1.95583	2.53405
//Входът e сума за конвертиране + входна валута + изходна валута. 
//    Изходът е едно число – преобразуваната сума по посочените по-горе курсове, 
//    закръглен до 2 цифри след десетичната точка. 

