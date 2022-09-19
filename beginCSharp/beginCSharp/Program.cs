using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace beginCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Roulette
            var game = true;

            //Guthaben und Einsatz
            int guthaben = 10000;
            int einsatz = 10;
            string wette = "gerade";
            Random k = new Random();
            bool autoplay = false;
            int lastbet = 0;
            bool lastgame = true;
            int gamecount = 0;
            do
            {
                
                //Random Nummer erzeugen
                int ranNum = k.Next(0, 37);
                

                if (autoplay == false)
                {
                    Console.WriteLine($"Dein Guthaben beträgt {guthaben}$");
                    Console.WriteLine("Soll der Computer übernehmen (y/n)?");
                    if (Console.ReadLine() == "y")
                    {
                        autoplay = true;
                    }
                }

                if (autoplay == false)
                {
                    Console.WriteLine("Wie viel möchtest du Wetten? (min 10$, max 1000$)");
                    einsatz = Convert.ToInt32(Console.ReadLine());

                    if (einsatz > 1000)             //Als Methode bauen
                    {
                        einsatz = 1000;
                    }
                    if (einsatz < 10)
                    {
                        einsatz = 10;
                    }
                    if (einsatz > guthaben)
                    {
                        einsatz = guthaben;
                    }

                    Console.WriteLine($"Möchtest du {einsatz}$ auf gerade oder ungerade setzen?");
                    wette = Console.ReadLine();

                }

                if(autoplay == true)
                {
                    einsatz = computerPlaceBet(guthaben, lastgame, lastbet);
                    wette = computerSelectField(k);
                }
                guthaben = guthaben - einsatz;

                //Check gerade oder ungerade
                string ausgang = "gerade";
                if ((ranNum % 2 == 0) && (ranNum != 0))
                {
                    ausgang = "gerade";
                }

                if ((ranNum % 2 != 0) && (ranNum != 0))
                {
                    ausgang = "ungerade";
                }
                if (ranNum == 0)
                {
                    ausgang = "null";
                }

                //Vergleich Wette und Ausgang
                if (ausgang == wette)
                {
                    guthaben = guthaben + (einsatz * 2);
                    Console.WriteLine($"Du hast {einsatz*2}$ gewonnen; Dein neues Guthaben beträgt {guthaben}$");
                    lastgame = true;
                }

                if ((ausgang != wette) && (ausgang !="null"))
                {
                    Console.WriteLine($"Du hast deinen Einsatz ({einsatz})$ verloren; Dein neues Guthaben beträgt {guthaben}$");
                    lastgame = false;
                }

                if (ausgang == "null")
                {
                    Console.WriteLine($"Es wurde eine Null");
                    einsatz = einsatz / 2;
                }
                lastbet = einsatz;
                //Nochmal spielen?

                if (autoplay == false)
                {
                    Console.WriteLine("Möchtest du nochmal spielen? (y/n)");
                    if (Console.ReadLine() == "n")
                    {
                        game = false;
                    }
                }
                if (guthaben <= 0)
                {
                    Console.WriteLine("Du hast kein Guthaben mehr, deshalb wird das Spiel beendet!");
                    game = false;
                }
                gamecount ++;
            } while (game == true);
            Console.WriteLine($"Es wurden {gamecount} Runden gespielt!");
            Console.ReadLine();
        }

        static int computerPlaceBet(int guthaben, bool lastgame, int lastbet)
        {
            int calcBet;
            if (guthaben >= 10000)
            {
                if (lastgame == true)
                {
                    calcBet = 10;
                }
                else
                {
                    calcBet = lastbet * 2;
                }
            }
            else
            {
                calcBet = (10000 - guthaben) * 2;
                
            }

            if (calcBet > 1000)
            {
                calcBet = 1000;
            }
            if (calcBet > guthaben)
            {
                calcBet = guthaben;
            }
           
            return calcBet;
        }
        static string computerSelectField(Random k)
        {
            if (k.Next(1, 2) == 2)
            { return "gerade"; }
            else
            { return "ungerade"; }
        }
    }
}