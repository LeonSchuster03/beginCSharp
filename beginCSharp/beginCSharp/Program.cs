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
            Console.WriteLine("Wähle eine Zahl");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wähle eine zweite Zahl");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int summe = zahl1 + zahl2;

            Console.WriteLine("Die Summe der Zahlen ist " + summe);

            Console.ReadLine();
        }
    }
}
