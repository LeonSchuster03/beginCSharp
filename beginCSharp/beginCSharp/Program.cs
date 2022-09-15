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
            Console.WriteLine("Gebe verschiedene Wörter mit einem ';' getrennt ein");
            string entry = Console.ReadLine();

            string []splitted_entry = entry.Split(';') ;

            int length = splitted_entry.Length;
            int i = 0;

            for (i = 0; i < length; i++)
            {
                Console.WriteLine(splitted_entry[i]);
            }
            
            Console.ReadLine();
            
        }
    }
}
