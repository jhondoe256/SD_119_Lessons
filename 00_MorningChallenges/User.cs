using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges
{
    
    public class User
    {

        //constructors -> you can have as many as you want
        //Create a blank constructor 
        public User() {  }
      
        public User(int id)
        {
            ID = id;
        }

        //and a full constructor for this class.
        public User(int id, string firstName, string lastName,DateTime birthDate)
        {
            //class properties always on the left
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        //start w/ properties first...
        //ID (an integer, with no setter), and BirthDate properties.
        public int ID { get;}
        
        //Give the user a FirstName, LastName,
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        //Bonus: Create a method that returns the full name of the user.
        public string HiMyNameIs()
        {
            return $"{FirstName} {LastName}";
        }

        //Double Bonus: Create a method that returns the age of the user in years.
        public int UserAge()
        {
            TimeSpan age = DateTime.Now - BirthDate;
            return (int)Math.Floor(age.TotalDays / 365.24);
        }
    }
}
