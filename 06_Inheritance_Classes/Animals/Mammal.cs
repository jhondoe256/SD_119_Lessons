using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes.Animals
{
    public class Mammal : Animal
    {
        public Mammal(string hairColor) : base()
        {
            Console.WriteLine("This is the Mammal constructor.");
            HasFur = true;
            NumberOfLegs = 4;
            HairColor = hairColor;
        }

        public string HairColor { get; set; } = "Hairless";

        // This is an implementation of the abstract method MakeSound()
        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
