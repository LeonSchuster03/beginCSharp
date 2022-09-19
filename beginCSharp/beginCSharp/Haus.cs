using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace beginCSharp
{
    public class Haus
    {
        double LaengeHaus { set; get; }
        double BreiteHaus { set; get; }
        double Hoehe { set; get; }
        string Dachart { set; get; }
        string Putzfarbe { set; get; }
        double AnzahlEtagen { set; get; }
        int Preis { set; get; }
        double Grundstueckslaenge { set; get; }
        double Grundstuecksbreite { set; get; }

        public Haus(double laengeHaus, double breiteHaus, double hoehe, string dachart, string putzfarbe, double anzahlEtagen, int preis, double grundstueckslaenge, double grundstuecksbreite)
        {
            laengeHaus = LaengeHaus;
            breiteHaus = BreiteHaus;
            hoehe = Hoehe;
            dachart = Dachart;
            putzfarbe = Putzfarbe;
            anzahlEtagen = AnzahlEtagen;
            preis = Preis;
            grundstueckslaenge = Grundstueckslaenge;
            grundstuecksbreite = Grundstuecksbreite;

        }
        public Haus() { }


        public static Haus AskUserForHaus()
        {
            Haus h = new Haus();
            Console.WriteLine("Welche Länge hat dein Haus?");
            h.LaengeHaus = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Welche Breite hat dein Haus?");
            h.BreiteHaus = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Welche Höhe ist dein Haus?");
            h.Hoehe = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Welche Dachart hat dei Haus?");
            h.Dachart = Console.ReadLine();

            Console.WriteLine("Was ist die Putzfarbe des Hauses?");
            h.Putzfarbe = Console.ReadLine();

            Console.WriteLine("Was ist der Preis deines Hauses?");
            h.Preis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Was ist die Grundstückslänge?");
            h.Grundstueckslaenge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Was ist die Grundstücksbreite?");
            h.Grundstuecksbreite = Convert.ToDouble(Console.ReadLine());
            return h;
        }
        public double GetGrundstueckQM()
        {
            
            return Grundstueckslaenge * Grundstuecksbreite;
        }
        public double GetWohnflaeche()
        {
            return (LaengeHaus * BreiteHaus * AnzahlEtagen);
        }

        public void ChangeColor(string Putzfarbe)
        {
            Console.WriteLine("Mit welcher Farbe soll das Haus neu gestrichen werden?");
            Putzfarbe = Console.ReadLine();
        }

        public void PrintHausInformation()
        {
            Console.WriteLine($"Dein Grundstück hat die Maße {Grundstueckslaenge} m x {Grundstuecksbreite} m, also {GetGrundstueckQM()} qm. Das Haus hat die Maße {LaengeHaus} x {BreiteHaus} und {AnzahlEtagen} mit eine Höhe von {Hoehe}. Deshalb hat das Haus eine Wohnfläche von {GetWohnflaeche()} qm. Die Dachart {Dachart} und die Putzfarbe ist {Putzfarbe} und das Haus hat {Preis} gekostet.");
        }

    }
}
