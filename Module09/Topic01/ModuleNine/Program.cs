using System;

namespace ModuleNine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person class driver
            // Use no-arg constructor
            Person musician1 = new Person();

            //set the properties of the musician1 object
            musician1.FirstName = "Tommy";
            musician1.LastName = "Tutone";

            // Use arg constructor
            Person musician2 = new Person("Peter", "Gabriel");

            // print the object with the class override ToString
            Console.WriteLine("Student One: " + musician1.ToString());
            // print the object without the class override ToString
            Console.WriteLine("Student Two: " + musician2);

            // Student Driver
            // Use defalut constructor and it's required input
            Student javaStudent = new Student("Jimmy", "Numaticon");

            //set the properties of the Student object
            javaStudent.StudentId = "0842B";
            javaStudent.YearInSchool = 2;

            // Use arg constructor
            Student cSharpStudent = new Student("Sally", "Computation", "06342A", 2);

            // print the object with the class override ToString()
            Console.WriteLine("Student is: " + javaStudent.ToString());

            // print the object without the class override ToString
            Console.WriteLine("Student is: " + cSharpStudent);

        }
    }
}
