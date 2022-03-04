using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {


            //programm küsib kasutajal sisestada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik";
            //Punane, Sinine, ROheLIne- toLower käsk - ei loe suuri tähti




            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();


            switch (userColor)

            {
                  case "punane": //if(userColor == "punane")
                    Console.WriteLine("Oled romantiline.");
                    break;
                  case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                  case "roheline":
                     Console.WriteLine("Oled looduse sõber.");
                    break;
                  default:
                     Console.WriteLine($"Oled {userColor} üksarvik.");
                    break;


            }

             Console.WriteLine("Kena päeva!");


        }
    }
}
