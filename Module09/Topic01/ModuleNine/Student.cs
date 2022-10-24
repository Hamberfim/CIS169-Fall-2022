using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleNine
{
    public class Student
    {
        private Person _personName;
        private string _studentId;
        private int _yearInSchool;

        // no-arg constructor
        //public Student()
        //{
        //    // call Person class no-arg constructor
        //    _personName = new Person();
        //    _studentId = "unknown";
        //    _yearInSchool = 0;
        //}

        // default constructor with implimentation of required Parent class arguments to hide that person class in the student class
        public Student(string firstname, string lastname)
        {
            // call Person class no-arg constructor
            _personName = new Person(firstname, lastname);
            _studentId = "unknown";
            _yearInSchool = 0;
        }

        // arg constructor
        public Student(string fname, string lname, string studentId, int yearInSchool)
        {
            // call Person class arg constructor
            _personName = new Person(fname, lname);

            // constructors args for this Student class
            StudentId = studentId;
            YearInSchool = yearInSchool;
        }

        // public Person PersonName { get => _personName; set => _personName = value; }  // hides the person class from the student class
        public string StudentId { get => _studentId; set => _studentId = value; }
        public int YearInSchool { get => _yearInSchool; set => _yearInSchool = value; }

        public override string ToString()
        {
            return _personName.ToString() + " student id: " + _studentId + " Year in school: " + _yearInSchool;
        }
    }
}
