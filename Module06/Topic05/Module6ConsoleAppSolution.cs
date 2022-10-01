using System;
using System.Collections.Generic;

namespace Module6
{
    class Program
    {
        // Sort List method
        public static void SortList(ref List<string> subjects)
        {
            subjects.Sort();
        }

        // Sort Array method
        public static void SortArray(ref double[] majorSubject)
        {
            Array.Sort(majorSubject);
        }

        // Search List method
        public static bool SearchList(List<string> subjects, string itemToSearch)
        {
            int existsInList;
            existsInList = subjects.BinarySearch(itemToSearch);
            if (existsInList >= 0)
                return true;
            return false;
        }

        // Search Array method
        public static bool SearchArray(double[] studentScore, double itemToFind)
        {
            int existsInList;
            existsInList = Array.FindIndex(studentScore, element => element == itemToFind);
            if (existsInList >= 0)
                return true;
            return false;
        }

        // Main method
        static void Main(string[] args)
        {
            // declare & initialize subjects list
            List<string> subjects = new List<string>();

            // add to subjects list
            subjects.Add("Computer Science");
            subjects.Add("Web Development");
            subjects.Add("Cybersecurity");
            subjects.Add("Networking");

            // sorts the list by calling the method SortList()
            SortList(ref subjects);

            // gets user input by prompting user to input a major
            Console.WriteLine("Please enter a major: ");
            string itemToSearch = Console.ReadLine();

            // Call SearchList() print a message to user if major exists
            if (SearchList(subjects, itemToSearch))
                Console.WriteLine(itemToSearch + " exists in major subjects List\n");
            else
                Console.WriteLine(itemToSearch + " does not exist in major subjects List\n");

            // Declare arrays of names, IDs, major subject & scores
            string[] studentName = { "Ayah", "Manual", "Mohamed", "Vasavi", "Rosa" };
            int[] studentId = { 322, 323, 334, 325, 318 };
            int[] majorSubject = { 0, 2, 1, 0, 3 };
            double[] studentScore = { 96.5, 88.7, 98.2, 90.8, 94.7 };

            // Print the name, id and major of each student
            Console.WriteLine("STUDENT SUMMARY");
            for (int index = 0; index < studentName.Length; index++)
            {
                Console.WriteLine(studentName[index] + ", ID# " + studentId[index] + ", Subject: " + subjects[majorSubject[index]]);
            }

            // Prompt use for score 
            double scoreToFind = 0;
            bool invalidInput = true;
            Console.Write("Please enter a score to find: ");
            while (invalidInput)
            {
                string input = Console.ReadLine();
                if (Double.TryParse(input, out scoreToFind){
                    invalidInput = false;
                }
                else
                {
                    Console.Write("\nPlease enter a valid score: ");
                }
            }
            if (SearchArray(studentScore, scoreToFind)) {
                Console.WriteLine("\n" + scoreToFind + " found in studentScores array\n");

            }
            else
            {
                Console.WriteLine("\n" + scoreToFind + " not found  in studentScores array\n");
            }

            // Call SortArray method for any appropriate array and print the sorted array.
            SortArray(ref studentScore);
            Console.Write("A sorted array of student scores: ");
            for (int index = 0; index < studentScore.Length; index++)
            {
                Console.Write(studentScore[index] + " ");
            }
            Console.WriteLine();
        }
    }
}