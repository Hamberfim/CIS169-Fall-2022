using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleNine
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        // no-arg Constructor
        public Person()
        {
            _firstName = "unknown";
            _lastName = "unknown";
        }

        // arg Constructor
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
    }
}
