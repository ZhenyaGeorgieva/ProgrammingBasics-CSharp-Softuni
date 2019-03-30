using System;
    class Program
    {
        static void Main()
        {
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            DateTime time = new DateTime();
            time = time.AddHours(hours); 
            time = time.AddMinutes(minutes + 15);
            Console.WriteLine(time.ToString("H:mm"));
        }
    }
}
