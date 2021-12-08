using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Classes
{
    public enum VehicleType { Car, Truck, SUV, Motorcycle, Spaceship, Helicopter };

    // A class is a definition for a custom type, or like a template
    public class Vehicle
    {
        // Properties (public-facing variables)
        // 1 access modifier
        // 2 type
        // 3 name
        // 4 getter and/or setter
        // 1     2     3       4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType Type { get; set; }

        public bool IsRunning { get; private set; }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }
        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turn off the vehicle.");
        }


        // Indicators
        public Indicator LeftIndicator { get; set; }
        public Indicator RightIndicator { get; set; }

        public void IndicateRight()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }
        public void IndicateLeft()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOn();
        }
        public void TurnOnHazards()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOn();
        }
    }

    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void TurnOn()
        {
            IsFlashing = true;
        }
        public void TurnOff()
        {
            IsFlashing = false;
        }
    }
}
