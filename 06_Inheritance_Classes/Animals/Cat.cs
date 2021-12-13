using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes.Animals
{
    public class Cat : Mammal
    {
        // public Cat() : base("orange")
        public Cat(string hairColor) : base(hairColor)
        {
            Console.WriteLine($"Creating a {hairColor} Cat");
            DietType = DietType.Carnivore;
        }

        public double ClawLength { get; set; }

        public override void MakeSound()
        {
            // base.MakeSound();
            Console.WriteLine("Meow!");
        }
    }
}
