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
            Console.WriteLine("Wie lang soll der Array sein?");
            int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Welche Zahl soll dem Array hinzugefügt werden?");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Suche größte Zahl
            int max = 0;
            foreach(int i in numbers)
            {
                if (i > max)
                {
                    max = i;
                }
                
            }

            //Suche kleinste Zahl
            int min = 999999999;
            foreach(int e in numbers)
            {
                if(e < min)
                {
                    min = e;
                }
            }

            //Durchschnitt berechnen
            float summe = 0;
            foreach(int a in numbers)
            {
                summe = summe + a;
            }


            //Zahlen ausgeben

            Console.WriteLine($"Die größte Zahl ist {max}");
            Console.WriteLine($"Die kleinste Zahl ist {min}");
            Console.WriteLine($"Der Durchschnitt ist {summe / numbers.Length}");




            Console.ReadLine();
        }
    }
}