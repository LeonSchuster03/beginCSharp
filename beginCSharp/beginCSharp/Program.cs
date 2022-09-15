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
            string replaced_entry = entry.Replace("U", "G").Replace("u", "g");

            Console.WriteLine("Der alte Text war: " + entry);
            Console.WriteLine("Der neue Text ist: " + replaced_entry);

            Console.ReadLine();
            
        }
    }
}
