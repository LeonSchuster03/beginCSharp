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
            Console.WriteLine("Gebe einen Text ein");
            string txt = Console.ReadLine();

            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt.ToUpper());

            Console.ReadLine();
        }
    }
}
