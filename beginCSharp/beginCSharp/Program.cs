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

            List<string> names = new List<string>();
            string repeat = "y";
            int i = 1;

            do
            {
                Console.WriteLine($"Gebe den {i}. Namen ein, den du hinzufügen willst");
                i++;
                names.Add(Console.ReadLine());
                Console.WriteLine("Willst du einen weiteren Namen einfügen ( y / n )?");
                repeat = Console.ReadLine();
            } while (repeat == "y");

            Console.WriteLine(" ");
            Console.WriteLine("Die Liste lautet:");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}