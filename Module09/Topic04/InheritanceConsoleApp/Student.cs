using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
* Name         : Console App: Inheritance - Student
* Author       : Anthony Hamlin
* Created      : 10/21/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is about inheritance. Utilizing a base class, a class that inherits from that bases, with methods and overrides.
*                      Input :  Student name, id, DOB
*                      Output: Student name, id, DOB, age
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace InheritanceConsoleApp
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private int _studentID;

        // Constructors
        public Student()
        {
            _firstName = "";
            _lastName = "";
            _dateOfBirth = new DateTime(1920, 01, 01);
            _studentID = 0;
        }

        public Student(string fName, string lName, DateTime DOB, int ID)
        {
            _firstName = fName;
            _lastName = lName;
            _dateOfBirth = DOB;
            _studentID = ID;
        }

        // Properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public int StudentID { get => _studentID; set => _studentID = value; }

        // Add method
        // returns a string of the student's last name, first name and id
        public virtual string MakeNamePlate()
        {
            return $"{_lastName}, {_firstName}, Id: {_studentID}";
        }

        public virtual int CalculateAge()
        {
            return DateTime.Now.Year - _dateOfBirth.Year;
        }

        public override string ToString()
        {
            return base.ToString() + ": Name: " + _firstName + " " + _lastName + " ID: " + _studentID;
        }
    }
}
