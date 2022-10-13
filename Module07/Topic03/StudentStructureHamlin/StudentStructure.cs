using System;
using System.Text.RegularExpressions;
/***************************************************************
* Name         : StudentStructure
* Author       : Anthony Hamlin
* Created      : 10/07/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is a Console App that uses a structure
*                      Input :  Student struct with fields of first name, last name,student id, major and year
*                      Output: Create a 'student' from the struct and display the 'student'
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace StudentStructure
{
    class StudentStructure
    {
        // Write a Console App that uses a structure that contains first name, last name,student id, major and year. Name your file StudentStructure.cs
        /* Define a structure, Student that contains
                * first name
                * last name
                * student id
                * major
                * year in school (1, 2, ...) */
        public struct Student
        {
            public string firstName;
            public string lastName;
            public int studentId;
            public string major;
            public int yearInSchool;
        }

        /* Write a method createStudent()
            * Accepts parameters for each of the characteristics
            * Makes a new student of type Student
            * Returns an object of type Student
            * Is defined outside of the struct
        * Add comments, including header (if you still need a reminder)*/
        public static Student createStudent(string firstName, string lastName, int studentId, string major, int yearInSchool)
        {
            Student student = new Student();
            student.firstName = firstName;
            student.lastName = lastName;
            student.studentId = studentId;
            student.major = major;
            student.yearInSchool = yearInSchool;

            return student;
        }

        /* Write a method displayStudent() that
            * Accepts a parameter of type Student
            * Returns a string
            * Is defined outside of the struct */
        public static string displayStudent(Student student)
        {
            return $"\nStudent Info: {student.firstName} {student.lastName} id#: {student.studentId}, Major: {student.major}, School Year: {student.yearInSchool}";
        }



        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";

            string studentIdStr = "";
            int studentId = 0;

            string major = "";

            string yearInSchoolStr = "";
            int yearInSchool = 0;

            /* In your Main method
                * Prompt the user for input needed for one student
                * Call createStudent()
                * Call displayStudent()
            * Add Exception Handling and Input Validation */
            Console.WriteLine("Enter student's first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter student's last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter student's major: ");
            major = Console.ReadLine();

            if ((!String.IsNullOrEmpty(firstName) && Regex.IsMatch(firstName, @"^[a-zA-Z]+$")) && (!String.IsNullOrEmpty(lastName) && Regex.IsMatch(lastName, @"^[a-zA-Z]+$")) && (!String.IsNullOrEmpty(major) && Regex.IsMatch(major, @"^[a-zA-Z]+$")))
            {
                Console.WriteLine("Enter student id number: ");
                studentIdStr = Console.ReadLine();
                if (int.TryParse(studentIdStr, out studentId))
                {
                    Console.WriteLine("Enter student school year: ");
                    yearInSchoolStr = Console.ReadLine();
                    if (int.TryParse(yearInSchoolStr, out yearInSchool))
                    {
                        Console.WriteLine(displayStudent(createStudent(firstName, lastName, studentId, major, yearInSchool)));
                    }
                    else
                    {
                        Console.WriteLine("School year input must be a integer. Program exiting.");
                        Environment.Exit(0);
                    }
                }
                else
                {

                    Console.WriteLine("Student id input must be a integer. Program exiting.");
                    Environment.Exit(0);
                }

            }
            else
            {
                Console.WriteLine($"\nFirst name, last name and school major must to be provided and can not contain numbers. Program exiting. ");
                Environment.Exit(0);
            }

        }
    }
}
