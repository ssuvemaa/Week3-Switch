using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai;

            //kui kasutaja sai 'A', konsool kuvab "Suurepärane!";
            //'B', konsool kuvab "Väga hea!";
            //'C', konsool kuvab "Hea!";
            //'D', konsool kuvab "Rahuldav!";
            //'E', konsool kuvab "Kasin!";
            //'F', konsool kuvab "Puudulik!";


            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus";
            //kasutame Switchi


             //NÄITAB NO ISSUES FOUND ja punast joont kuhugile ei teki, aga kui tööle panen siis lööb errori ette, kuigi kood peaks õige olema :)
            //kui vajutada "Would you like to continue and run the last successful build?"- "Yes" siis toimib korrektselt.

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");

                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");

                    break;
                case 'C':
                    Console.WriteLine("Hea!");

                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");

                    break;
                case 'E':
                    Console.WriteLine("Kasin!");

                    break;
                case 'F':
                    Console.WriteLine("Puudlik!");

                    break;
                default:
                    Console.WriteLine($"Vale väärtus!");

                    break;



            }

        }
    }
}