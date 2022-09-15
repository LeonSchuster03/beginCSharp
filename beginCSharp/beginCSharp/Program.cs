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
            Console.WriteLine("Wähle den Buchstaben, nach dem gesucht werden soll");
            string buchstabe = Console.ReadLine();
            string namen = ("Jan, Philipp, Erwin, Leon, Robert, Jonas, Marie, Lukas, Mona, Andreas, Marcello, Robin, Hannes");
            string[] liste = namen.Split(',');

            for(int i = 0; i < liste.Length; i++)
            {
                if (liste[i].Contains(buchstabe))
                {
                    Console.Write(liste[i]);
                    i++;
                }
            }



            Console.ReadLine();
        }
    }
}
