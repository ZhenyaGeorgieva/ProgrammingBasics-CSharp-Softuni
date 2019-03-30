using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07GlasWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupVolume = int.Parse(Console.ReadLine());
            int counter = 0;
            int overalVolume = 0;
            int volumeButton = 0;
            string buttons = " ";

            while ((buttons=Console.ReadLine())!=null&&overalVolume<cupVolume)
            {
                switch (buttons)
                {
                    case "Easy":
                        volumeButton = 50;break;
                    case "Medium":
                        volumeButton = 100; break;
                    case "Hard":
                        volumeButton = 200;break;
                }
                overalVolume = overalVolume + volumeButton;
                counter++;
            }
            if (overalVolume>cupVolume)
            {
                int spiltWater = overalVolume - cupVolume;
                Console.WriteLine($"{spiltWater}ml has been spilled.");
            }
            else
            {
                Console.WriteLine($"The dispenser has been tapped {counter} times.");
            }

        }
    }
}
//Всеки офис си има диспенсър за вода. Напишете програма, 
//която отчита дали служител от офиса е успял да напълни чашата си успешно.
//Диспенсърът има три бутона :
//•	Easy - лесен(50 милилитра)
//•	Medium - среден(100 милилитра)
//•	Hard - силен(200 милилитра)
//Ще получите обемът на чашата и на всеки следващ ред кой бутон е бил натиснат.
//    Ако чашата се напълни или прелее програмата приключва.
//Ако чашата прелее отпечатайте колко вода е била излята. 
//        При успешно напълване отпечатайте броят на натисканията на бутона.
