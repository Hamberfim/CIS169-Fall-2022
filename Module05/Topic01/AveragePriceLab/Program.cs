using System;

namespace AveragePriceLab
{
    class Program
    {
        /*
         *  Create a Console App that uses a while loop to calculate the average of 3 ages.
         *  Input integers, but use the appropriate data type for the average. 
         *  Generally, you use a while to do something while a condition is true. You can use a while loop to execute a certain number of times. *While* this is not the best use of the while loop and another loop is generally more appropriate, it follows the pattern below
         *      Declare and initialize an age sum variable (ageTotal)
         *      Declare an intialize an average variable (average)
         *      Declare and initialize a number of inputs variable (numAges)  (eg, 3)

         *  while ( there is still more input) 
         *  { 
         *      // Prompt user for input 
         *      // Get input and add to ageTotal
         *      // Increment counter (here called numAges)
         *  }
         *  
         *  Calculate average of the the ages. 
         *  Output average with 2 decimal points precision.
         */
        static void Main(string[] args)
        {
            // Declare and initialize an age sum variable (ageTotal)
            int ageTotal = 0;
            string ageTotalString = "";
            int ageInput = 0;
            // Declare and intialize an average variable(average)
            double average = 0;
            // Declare and initialize a number of inputs variable (numAges)  (eg, 3)
            int numAges = 3;
            // counter
            int counter = 0;

            while (counter < numAges)
            {
                // Prompt user for input
                Console.WriteLine("Enter an age: ");
                ageTotalString = Console.ReadLine();
                // Get input and add to ageTotal
                if (int.TryParse(ageTotalString, out ageInput))
                {
                    ageTotal += ageInput;
                }
                else
                {
                    Console.WriteLine("Age input must be an integer. Exiting Program!");
                    break;
                }
                // Increment counter (here called numAges)
                counter++;
            }

            // Calculate average of the the ages.
            average = (double)ageTotal / numAges;
            // Output average with 2 decimal points precision.
            Console.WriteLine($"The age average is {average:f2}");
        }
    }
}
