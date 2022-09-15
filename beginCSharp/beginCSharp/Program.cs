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
            Console.WriteLine("Schreibe einen Text");
            string entry = Console.ReadLine();
            int length = Convert.ToInt32(entry.Length);

            Console.WriteLine("Die Länge des eingegebenen Textes ist " + length);

            Console.ReadLine();
            
        }
    }
}
