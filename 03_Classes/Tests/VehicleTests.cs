using _03_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_Classes.Tests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Dodge";
            firstVehicle.Model = "Journey";
            firstVehicle.Mileage = 100000;
            firstVehicle.Type = VehicleType.SUV;

            Console.WriteLine($"Model: {firstVehicle.Model}");

            Vehicle secondVehicle = new Vehicle();
            secondVehicle.Type = VehicleType.Spaceship;

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(firstVehicle);
            vehicles.Add(secondVehicle);
        }
    }
}
