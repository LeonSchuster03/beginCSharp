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
            Random k = new Random();

            do
            {
                //Random Nummer erzeugen
                int ranNum = k.Next(0, 36);
                Console.WriteLine($"Dein Guthaben beträgt {guthaben}$");
                Console.WriteLine("Wie viel möchtest du Wetten? (min 10$, max 1000$)");
                einsatz = Convert.ToInt32(Console.ReadLine());
                if(einsatz > 1000)
                {
                    einsatz = 1000;
                }
                if(einsatz < 10)
                {
                    einsatz = 10;
                }
                if(einsatz > guthaben)
                {
                    einsatz = guthaben;
                }
                Console.WriteLine($"Möchtest du {einsatz}$ auf gerade oder ungerade setzen?");
                string wette = Console.ReadLine();


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
                    guthaben = guthaben + einsatz;
                    Console.WriteLine($"Du hast {einsatz}$ gewonnen; Dein neues Guthaben beträgt {guthaben}$");
                }

                if (ausgang != wette)
                {
                    guthaben = guthaben - einsatz;
                    Console.WriteLine($"Du hast deinen Einsatz ({einsatz})$ verloren; Dein neues Guthaben beträgt {guthaben}$");
                }

                if (ausgang == "null")
                {
                    Console.WriteLine($"Es wurde eine Null, deshalb erhältst du deinen Einsatz zurück");
                }

                //Nochmal spielen?
                Console.WriteLine("Möchtest du nochmal spielen? (y/n)");

                if(Console.ReadLine() == "n")
                {
                    game = false;
                }

                if(guthaben <= 0)
                {
                    Console.WriteLine("Du hast kein Guhaben mehr, deshalb wird das Spiel beendet!");
                    game = false;
                }

            } while (game == true);
        }
            
        
    }
}