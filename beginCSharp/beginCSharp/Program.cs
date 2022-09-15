using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Schreibe einen Text");
            string entry = Console.ReadLine();
            int length = Convert.ToInt32(entry.Length);

            Console.WriteLine("Die Länge des eingegebenen Textes ist " + length);

            Console.ReadLine();*/
            Console.WriteLine("Wähle eine Fließkommazahl");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wähle eine zweite Fließkommazahl");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            double summe = zahl1 + zahl2;
            Console.Write("Die Summe der Zahlen ist: " + summe);

            Console.ReadLine();
            
        }
    }
}
