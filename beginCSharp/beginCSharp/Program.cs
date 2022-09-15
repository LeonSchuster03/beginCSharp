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
            int a = 0;
            int b = 0;

            for (int i = 0; i <= number; i++)
            {
                
                
                b = a + i;
                Console.WriteLine(b);
                a = b;
            }

            Console.ReadLine();
        }
    }
}
