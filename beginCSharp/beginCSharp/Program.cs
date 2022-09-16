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
            for(int i = 1; i <= 100; i++)
            {
                int zahl = i;
                if ((zahl % 3 == 0) && !(zahl % 5 == 0))
                {
                    Console.WriteLine("Fizz");
                }

                else if ((zahl % 5 == 0) && !(zahl % 5 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else if ((zahl % 3 == 0) && (zahl % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(zahl);
                }
            
            }

            Console.ReadLine();
        }
    }
}
