using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace beginCSharp
{
    public class Lion : Animals
    {
        public Lion(string name, int age, int size, int lifespan, float weight, bool fur, string sound)
        {
            Name = name;
            Age = age;
            Size = size;
            Lifespan = lifespan;
            Weight = weight;
            Fur = fur;

        }
        
        public override void Sound()
        {
            Console.WriteLine("ROOOAAAAAAARRR");
        }
    }

}
