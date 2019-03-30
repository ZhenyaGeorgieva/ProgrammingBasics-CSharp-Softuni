using System;
    class Program
    {
        static void Main()
        {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        string word3 = word1.ToLower();
        string word4 = word2.ToLower();

        if (word3==word4)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
    }

//Да се напише програма, която чете две думи, въведени от потребителя,
//и проверява дали са еднакви. 
//Да не се прави разлика между главни и малки думи. Да се изведе "yes" или "no". 
//    Подсказка: използвайте if-else конструкция.Преди сравняване на 
//    думите ги обърнете в долен регистър: word = word.toLower().
