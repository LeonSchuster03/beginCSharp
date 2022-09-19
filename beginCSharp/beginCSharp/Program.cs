using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace beginCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             

            List<Animals> tiere = new List<Animals>();
            tiere.Add(new Lion("Alex", 16, 180, 30, 120, true, "ROOOOAAAAR"));
            tiere.Add(new Ape("Wukong", 10, 120, 25, 60, true, "Apes together strong"));
            tiere.Add(new Zebra("Philipp", 26, 170, 40, 75, true, "*zebra noises*"));
            tiere.Add(new Shark("Herbert", 10, 155, 75, 105, false, "*Werid shark noises"));

            foreach(Animals a in tiere)
            {
                a.PrintAnimalInfo();
                a.eat();
                a.drink();
                a.eat();
                a.Hauttyp();
                a.scream();

            }


            

            Console.ReadLine();
        }
        
    }
}