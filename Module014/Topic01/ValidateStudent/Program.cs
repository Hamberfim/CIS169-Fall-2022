using System;
/***************************************************************
* Name         : ValidateStudent for method ValidateStudentID()
* Author       : Anthony Hamlin
* Created      : 11/21/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is class to hold a ValidateStudentID() method driven by TDD
*                      Input : TDD's
*                      Output: TDD's
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace ValidateStudent
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        // ValidateStudentID() accepts a string - assuming data type to be string here
        private string _studentId;

        public Student()
        {
            _firstName = "unknown";
            _lastName = "unknown";
            _studentId = "unknown";
        }

        public Student(string firstName, string lastName, string studentId)
        {
            _firstName = firstName;
            _lastName = lastName;
            _studentId = studentId;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string StudentId { get => _studentId; set => _studentId = value; }

        // a boolean method ValidateStudentID() that accepts a string
        public bool ValidateStudentID(string studentIdValue)
        {
            int studId;
            char firstCharStr = studentIdValue[0];
            char secondCharStr = studentIdValue[1];

            if (!Int32.TryParse(studentIdValue, out studId))
            {
                return false;
            }
            else if (studentIdValue.Length != 9)
            {
                return false;
            }
            else if (secondCharStr - '0' != 0)  // secondCharStr resolves to a number
            {
                return false;
            }
            else if (firstCharStr - '0' != 9)  // firstCharStr resolves to a number
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + ": Name: " + _firstName + " " + _lastName + " ID: " + _studentId;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
