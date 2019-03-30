using System;
    class Program
    {
        static void Main()
        {
        double bgn = double.Parse(Console.ReadLine());
        double usd = bgn * 1.79549;
        Console.WriteLine("{0:F2} BGN",usd);
        }
    }


////2.	Конзолен конвертор: USD към BGN
//Напишете програма за конвертиране на щатски долари(USD) в български лева(BGN).
//Закръглете резултата до 2 цифри след десетичната запетая.
//    Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.
