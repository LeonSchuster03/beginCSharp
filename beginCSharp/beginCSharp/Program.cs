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
            Console.WriteLine("Gebe einen Zahl ein");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i >= 1; i-=1)
            {
                Console.WriteLine(i-1);
                
            }

            Console.ReadLine();
        }
    }
}
