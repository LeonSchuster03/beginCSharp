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
            Console.WriteLine("Wähle eine Zahl");
            double zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wähle eine zweite Zahl");
            double zahl2 = Convert.ToDouble(Console.ReadLine());
            double ergebnis = 0;
            Console.WriteLine("Wähle einen Operator ( + , - , * , / , % ");
            string zeichen = Console.ReadLine();
            switch (zeichen)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    Console.WriteLine($"{zahl1} + {zahl2} = {ergebnis}");
                    break;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    Console.WriteLine($"{zahl1} - {zahl2} = {ergebnis}");
                    break;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    Console.WriteLine($"{zahl1} * {zahl2} = {ergebnis}");
                    break;
                case "/":
                    ergebnis = zahl1 / zahl2;
                    Console.WriteLine($"{zahl1} / {zahl2} = {ergebnis}");
                    break;
                case "%":
                    ergebnis = zahl1 % zahl2;
                    Console.WriteLine($"{zahl1} % {zahl2} = {ergebnis}");
                    break;
                default:
                    Console.WriteLine("Bitte versuche es erneut und wähle einen richtigen Operator aus");
                    break;
            }

            Console.ReadLine();
        }
    }
}