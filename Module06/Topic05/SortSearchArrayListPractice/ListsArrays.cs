using System;
using System.Collections.Generic;

namespace SortSearchArrayListPractice
{
    class ListsArrays
    {
        public static void SortList(ref List<string> listToSort)
        {
            // Call List method to sort list 
            listToSort.Sort();
        }

        public static void SortArray(ref double[] arrayToSort)
        {
            // Call Array method to sort
            Array.Sort(arrayToSort);
        }

        public static bool SearchList(List<string> list, string itemToSearch)
        {
            int existsInList;
            existsInList = list.BinarySearch(itemToSearch);
            if (existsInList >= 0)
            {
                return true;
            }
            return false;
        }

        public static bool SearchArray(double[] studentScore, double itemToFind)
        {
            int existsInList;
            existsInList = Array.FindIndex(studentScore, element => element == itemToFind);
            if (existsInList >= 0)
            {
                return true;
            }
            return false;
        }




        static void Main(string[] args)
        {
            // Declare and Initialize a list names subjects
            List<string> subjects = new List<string>();

            // Add using List method: "Computer Science", "Web Development", "Cybersecurity" and "Networking"
            subjects.Add("Computer Science");
            subjects.Add("Web Development");
            subjects.Add("Cybersecurity");
            subjects.Add("Networking");
            foreach (var item in subjects)
            {
                Console.WriteLine(item);
            }

            // Sort the list by calling the method SortList()
            SortList(ref subjects);
            foreach (var item in subjects)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Get user input by prompting user to input a major
            Console.WriteLine("Enter a major: ");
            string userMajor = Console.ReadLine();

            // Call SearchList() print a message to user if major exists
            if (SearchList(subjects, userMajor))
            {
                Console.WriteLine($"We have '{userMajor}' as a major.");
            }
            else
            {
                Console.WriteLine($"We do not have '{userMajor}' as a major.");
            }
            Console.WriteLine();

            // Declare an array of string to store student names, name the array studentName
            string[] studentName = { "Ayah", "Manual", "Mohamed", "Vasavi", "Rosa" };

            // Declare an array of int to store student ids, name the array studentId
            int[] studentId = { 322, 323, 334, 325, 318 };

            // Initialize the above arrays to have {(Ayah, 322), (Manual, 323), (Mohamed, 334), (Vasavi, 325), (Rosa, 318)}
            // ?? this seems incorrect C# Arrays can only hold one data type

            // Declare an array of int to store the index of their major, name the array majorSubject
            // Initialize the above array to have the following { 0, 2, 1, 0, 3 } 
            int[] majorSubject = { 0, 2, 1, 0, 3 };

            // Declare an array of double to store scores, name it studentScore, add some valid test scores
            double[] studentScore = { 99.6, 98.7, 99.2, 89.9, 99.5 };

            // Print the name, id and major of each student
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine($"Name: {studentName[i]} Id: {studentId[i]} Major: {subjects[majorSubject[i]]}");
            }

            // Prompt user for input until a valid score to search is entered
            double findScore = 0;
            bool findScoreIsValid = false;
            Console.WriteLine("Enter a score to search for: ");
            while (!findScoreIsValid)
            {
                string findScoreStr = Console.ReadLine();
                if (Double.TryParse(findScoreStr, out findScore))
                {
                    findScoreIsValid = true;
                }
                else
                {
                    Console.WriteLine("Score must be a number, i.e., 97.6: ");
                }
            }
            Console.WriteLine();

            // Call SearchArry and print if score is found 
            if (SearchArray(studentScore, findScore))
            {
                Console.WriteLine($"{findScore} was found in the student scores.");
            }
            else
            {
                Console.WriteLine($"{findScore} was not found in the student scores.");
            }

            Console.WriteLine();
            // Call SortArray method for any appropriate array and print the sorted array.
            SortArray(ref studentScore);
            foreach (var item in studentScore)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
