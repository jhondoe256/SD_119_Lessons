using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public class Person
    {
        // fields
        private string _firstName;
        private string _lastName;
        // properties
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Name
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_firstName))
                {
                    if (string.IsNullOrWhiteSpace(_lastName))
                    {
                        return "Unnamed";
                    } else
                    {
                        return _lastName;
                    }
                } else if (string.IsNullOrWhiteSpace(_lastName))
                {
                    return _firstName;
                } else
                {
                    return $"{_firstName} {_lastName}";
                }

                // string fullName = $"{_firstName} {_lastName}";
                // return string.IsNullOrWhiteSpace(fullName) ? "Unnamed" : fullName;
            }
        }
        // methods
        public void SetFirstName(string name)
        {
            _firstName = name;
        }
        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
