using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginCSharp
{
    public abstract class Vehicle
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public int CCM { get; set; }
        public int Tyres { get; set; }
        public string Color { get; set; }

        public bool MotorLauft { get; set; }
        public int Geschwindigkeit { get; set; }

        public void Starten()
        {
            if(MotorLauft) // == true kann weg, weil bool
            {
                Console.WriteLine("Motor läuft schon, kann ihn nicht starten!");
            }
            else
            {
                MotorLauft = true;
                Console.WriteLine("Motor wird gestartet! .. WRRRRUUMMM");
            }
        }

        public void Beschleunigen()
        {
            Geschwindigkeit += 10;
        }
        public void Bremsen()
        {
            if(Geschwindigkeit <= 0)
            {
                Console.WriteLine($"{this.GetType().Name} steht bereits!");
            }
            else
            {
                Geschwindigkeit -= 10;
                Console.WriteLine($"{this.GetType().Name} Fahrzeug wird gebremst!");
            }

        }


    }


}
