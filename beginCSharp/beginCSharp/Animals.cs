using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace beginCSharp
{
    public abstract class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Size { get; set; }
        public int Lifespan { get; set; }
        public float Weight { get; set; }
        public bool Fur { get; set; }


        public bool hungry { get; set; }
        public bool thirsty { get; set; }

        public string sound { get; set; }

        public void drink()
        {
            if (thirsty)
            {
                Console.WriteLine($"{this.GetType().Name} hat etwas getrunken!");
                thirsty = false;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} ist nicht durstig!");
            }
        }
        public void eat()
        {
            if (hungry)
            {
                Console.WriteLine($"{this.GetType().Name}hat etwas gefressen!");
                hungry = false;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} ist nicht hungrig!");
            }
        }
        public void scream()
        {
         
                Console.WriteLine($"{this.GetType().Name}hat gebrüllt!");
                hungry = false;

        }
        public void Hauttyp()
        {
            if (Fur)
            {
                Console.WriteLine($"{this.GetType().Name} hat ein Fell!");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} hat kein Fell!");
            }
        }
        public virtual void Sound()
        {
            Console.WriteLine("SOUND");
        }
        public void PrintAnimalInfo()
        {
            Console.WriteLine($"{Name} ist ein {Age} Jahre alter und {Size} cm großer {this.GetType().Name}."
                + $"Er hat eine Lebensdauer von {Lifespan} und wiegt {Weight} kg.");
        }
    }   
}
