using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Classes
{
    public class Person
    {
        // empty constructor (comes with every object by default)
        public Person() {}
        // full constructor
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }


        public string FirstName { get; set; }

        // backing field
        private string _lastName;
        public string LastName {
            get { return _lastName[0].ToString().ToUpper() + _lastName.Substring(1); }
            set { _lastName = value; }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get {
                TimeSpan age = DateTime.Now - DateOfBirth;
                return (int) Math.Floor(age.TotalDays / 365.24);
            }
        }


        public Vehicle Vehicle { get; set; }
    }
}
