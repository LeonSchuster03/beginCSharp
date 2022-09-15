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

            Console.WriteLine(entry.PadLeft(30, 'y'));

            Console.ReadLine();
            
        }
    }
}
