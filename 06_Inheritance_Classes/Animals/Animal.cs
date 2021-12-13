using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes.Animals
{
    public enum DietType { Herbivore = 1, Carnivore, Omnivore }

    // abstract means I can't make any Animals
    // But I can make other classes that derive from Animal, and use those
    public abstract class Animal
    {
        // fields
        // constructors
        public Animal()
        {
            Console.WriteLine("This is the Animal constructor");
        }
        // properties
        public int NumberOfLegs { get; set; }
        public DietType DietType { get; set; }
        public bool HasFur { get; set; }
        // methods
        public void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }

        // only abstract classes can have abstract methods
        // abstract methods don't have a body
        public abstract void MakeSound();
    }
}
