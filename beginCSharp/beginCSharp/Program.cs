using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace beginCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int random_number = r.Next(1, 100);
            var game = true;
            int tries = 0;
            Console.WriteLine("Wähle eine Zahl zwischen 1 und 100");

            while (game == true) 
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == random_number)
                {
                    Console.WriteLine($"Du hast gewonnen, du hast {tries} versuche gebraucht");
                    game = false;
                }
                else if (guess > random_number)
                {
                    Console.WriteLine("Die Zahl ist zu groß");
                    tries++;
                }
                else if (guess < random_number)
                {
                    Console.WriteLine("Die Zahl ist zu klein");
                    tries++;
                }

            }

            Console.ReadLine();
        
            }
    }
}
