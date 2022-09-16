using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
            //Aufgabe 2
            List<int> numbers = new List<int>() { 5, 3, 7};

            //Aufgabe 3
            var repeat = true;
            do
            {
                Console.WriteLine("Bitte gib eine Zahl ein ");
                numbers.Add(Convert.ToInt16(Console.ReadLine()));
                Console.WriteLine("Willst du noch eine Zahl eingeben? (y/n)");
                var userInput = Console.ReadLine();
                if (userInput == "n")
                {
                    repeat = false;
                }
            } while (repeat);

            //Aufgabe 4           
            printList(numbers);

            Console.ReadKey();
            
            //Aufgabe 5
            numbers.Insert(2, 99);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Aufgabe 6
            numbers.AddRange(new int[]
            {
                91,
                92,
                93,
            });
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(" ");

            //Aufgabe 7
            numbers.RemoveAt(1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(" ");

            //Aufgabe 8
            numbers.Remove(99);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(" ");

            //Aufgabe 9
            numbers.RemoveAt(numbers.Count - 1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(" ");

            //Aufgabe 10
            numbers.Sort();                 //sortieren und ausgeben
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(" ");


            numbers.Reverse();              //reversen und ausgeben
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(" ");



            //Aufgabe 11
            foreach (var number in numbers)
            {
                if(number > 80)
                {
                    numbers.Remove(number);
                }
            }

            


        }

        //Methoden Aufgabe 1

        static void printList(List<int> List)
        {
            foreach (var i in List)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("_________________");
        }




        static double Div(double z1, double z2)
        {
            double quotient = z1 / z2;
            return quotient;
        }
            //static  Rückgabetyp  MethodenName  (Parameter)


        
        
    }
}