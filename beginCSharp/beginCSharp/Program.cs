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
            Console.WriteLine("Wie lang soll der Array sein?");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Welche Zahl soll dem Array hinzugefügt werden?");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            foreach(int number in array)
            {
                Console.WriteLine(number);
            }
            
            // namen2[i] += " 123"

            Console.ReadLine();
        }
    }
}
