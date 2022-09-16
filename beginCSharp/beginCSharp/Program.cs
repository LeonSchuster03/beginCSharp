using System;
using System.Collections.Generic;
using System.Linq;
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

            names.Add("Leon");
            names.Add("Erwin");
            names.Add(Console.ReadLine());

            Console.ReadLine();
        }
    }
}