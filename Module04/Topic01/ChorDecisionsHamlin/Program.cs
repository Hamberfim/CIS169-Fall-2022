using System;

namespace ChorDecisionsHamlin
{
    class Program
    {
        private static string ChoresByAge(int ageOfChild)
        {
            /* Children learn as they grow. They are able to do more household chores as they mature. 
             * Use if-else in a Console App that prompts for user input of a child's age, 
             * sends it to a method ChoresByAge() that creates a string of chores they are able to do. 
               For your method, accept the child's age as a parameter and return a string that lists possible chores. 
               Print that string in the Main method. In the Main, ask for the child's age performing input validation. 
               If the user submits non-numeric or invalid (negative age) input, exit Main with the appropriate error message. 
               For non-numeric or non-integer number, use try/catch and for negative number, check with if statement.

                Age below 2
                    Too young for chores
                Ages 2-3
                    Pick up toys and books
                    Put garbage in trash can
                    Put dirty laundry in hamper
                    Put laundry in drawer
                Ages 4-6
                    All previous chores
                    Take care of pets
                    Set and clear the table
                    Make bed
                Ages 7-11
                    All previous chores
                    Fold laundry 
                    Sweep and vacuum
                    Take out trash
                    Meal prep
                Ages 12+
                    All previous chores
                    Babysit siblings
                    Wash windows
                    Laundry
                    Mow the lawn
     */
            string choreList = "";
            // Add if logic to build string
            if(ageOfChild >= 0 && ageOfChild < 2)
            {
                choreList = "Too young for chores";
            } else if(ageOfChild >= 2 && ageOfChild < 4)
            {
                choreList = "Pick up toys and books.\nPut garbage in trash can.\nPut dirty laundry in hamper.\nPut laundry in drawer.";
            } else if (ageOfChild >= 4 && ageOfChild < 7)
            {
                choreList = "Pick up toys and books.\nPut garbage in trash can.\nPut dirty laundry in hamper.\nPut laundry in drawer.\nTake care of pets.\nSet and clear the table.\nMake bed.";
            }
            else if (ageOfChild >= 7 && ageOfChild < 12)
            {
                choreList = "Pick up toys and books.\nPut garbage in trash can.\nPut dirty laundry in hamper.\nPut laundry in drawer.\nTake care of pets.\nSet and clear the table.\nMake bed.\nFold laundry.\nSweep and vacuum.\nTake out trash.\nMeal prep.";
            } else if(ageOfChild >= 12)
            {
                choreList = "Pick up toys and books.\nPut garbage in trash can.\nPut dirty laundry in hamper.\nPut laundry in drawer.\nTake care of pets.\nSet and clear the table.\nMake bed.\nFold laundry.\nSweep and vacuum.\nTake out trash.\nMeal prep.\nBabysit siblings.\nWash windows.\nLaundry.\nMow the lawn.";
            } else
            {
                choreList = "Child's age can not be a negative number. Exiting Program!";
            }
            return choreList;
        }


        static void Main(string[] args)
        {
            int childAge;
            string choresList;
            // Get child's from user input
            Console.WriteLine("Enter the childs age: ");
            try
            {
                childAge = Convert.ToInt32(Console.ReadLine());
                // call method
                choresList = ChoresByAge(childAge);
                // print choresList 
                Console.WriteLine(choresList);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"ERROR: {e.Message}. \nExiting Program!");
            }  
        }
    }
}
