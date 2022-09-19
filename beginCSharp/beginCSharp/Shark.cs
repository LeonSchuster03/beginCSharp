﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace beginCSharp
{
    public class Shark: Animals
    {
        public Shark(string name, int age, int size, int lifespan, float weight, bool fur, string sound)
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
            Console.WriteLine("BABY SHARK DUDUDUDUDU");
        }
    }
    
}
