using _06_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void NameTest()
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            // person.SetFirstName("Terry");
            person.SetLastName("Brown");
            Console.WriteLine(person.Name);
        }

        [TestMethod]
        public void EmployeeTest()
        {
            Employee employee = new Employee();
            employee.Email = "something@somewhere.com";
            employee.SetFirstName("Job");
            employee.SetLastName("Worker");
            employee.HireDate = new DateTime(2020, 01, 01);
            Console.WriteLine($"{employee.Name} was hired on {employee.HireDate}");

            HourlyEmployee hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.Email = "sadfgd";
            hourlyEmployee.SetFirstName("sdsfgd");
            hourlyEmployee.HireDate = DateTime.Now;
            hourlyEmployee.HourlyWage = 30;
        }
    }
}
