using System;
/***************************************************************
* Name         : Console App: Inheritance - Program driver
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== From instructors drivers ===");
            // instructors student drivers
            string fname = "Ren", lname = "Stevens";
            int id = 22;
            DateTime dob = new DateTime(1984, 3, 20);
            Student ren = new Student(fname, lname, dob, id);
            Console.WriteLine(ren.ToString());

            // studentwork driver
            string fname2 = "Kim", lname2 = "Possible";
            int id2 = 32;
            DateTime dob2 = new DateTime(2002, 6, 7);
            decimal pay = 10.15M;
            double hours = 19;
            Student kim = new StudentWorker(pay, hours, fname2, lname2, dob2, id2);
            Console.WriteLine(kim.ToString());

            Console.WriteLine();

            // Student Driver
            Console.WriteLine("=== My drivers ===");
            // no-arg constructor
            Student tim = new Student();
            tim.FirstName = "Tim";
            tim.LastName = "Thompson";
            tim.StudentID = 01245;
            tim.DateOfBirth = new DateTime(1966, 04, 03);
            Console.WriteLine(tim.ToString());
            Console.WriteLine("Student Info: " + tim.MakeNamePlate());
            Console.WriteLine("Student Age: " + tim.CalculateAge());

            // arg constructor
            Student karen = new Student("Karen", "Smith", new DateTime(1956, 05, 10), 097654);
            Console.WriteLine(karen.ToString());
            Console.WriteLine("Student Info: " + karen.MakeNamePlate());
            Console.WriteLine("Student Age: " + karen.CalculateAge());

            Console.WriteLine();
            // StudentWorker Driver
            // no-arg constructor
            StudentWorker stephanie = new StudentWorker();
            stephanie.Pay = 19.00m;
            stephanie.Hours = 12;
            stephanie.FirstName = "Stephanie";
            stephanie.LastName = "Brown";
            stephanie.StudentID = 06598;
            stephanie.DateOfBirth = new DateTime(1987, 03, 13);
            Console.WriteLine(stephanie.ToString());
            Console.WriteLine("Student Info: " + stephanie.MakeNamePlate());
            Console.WriteLine("Student Age: " + stephanie.CalculateAge());
            Console.WriteLine($"Student Payroll: {stephanie.CalcuatePay():c2}");

            // arg constructor  - decimal pay, double hours, string fname2, string lname2, DateTime dob2, int id2
            StudentWorker bill = new StudentWorker(22.00m, 17, "Bill", "McBryan", new DateTime(1985, 12, 25), 674352);
            Console.WriteLine(bill.ToString());
            Console.WriteLine("Student Info: " + bill.MakeNamePlate());
            Console.WriteLine("Student Age: " + bill.CalculateAge());
            Console.WriteLine($"Student Payroll: {bill.CalcuatePay():c2}");


        }
    }
}
