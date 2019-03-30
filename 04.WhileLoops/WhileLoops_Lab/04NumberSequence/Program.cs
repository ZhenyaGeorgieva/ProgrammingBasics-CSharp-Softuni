using System;
    class Program
    {
        static void Main(string[] args)
        {

            int maxvalue = int.MinValue;
            int minvalue = int.MaxValue;

            while (true)
            {
                string command = Console.ReadLine();

            if (command == "END")
                {
                    break;
                }
                int a = int.Parse(command);
                if (a < minvalue)
                {
                    minvalue = a;
                }
                if (a > maxvalue)
                {
                    maxvalue = a;
                }
            }
            Console.WriteLine($"Max number: {maxvalue}");
            Console.WriteLine($"Min number: {minvalue}");
        }
    }
//4.	Редица цели числа
//Напишете програма, която чете цели числа, докато не получи командата "END". 

//Принтирайте най-голямото и най-малкото число сред въведените.


