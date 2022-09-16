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
            Console.WriteLine("Wir holen uns jetzt eine Zahl aus Number()");
            int zahl = Number();
            Console.WriteLine(zahl);
            Console.ReadLine();
        }

        static int Number()
        {
            return 15;
        }
    }
}