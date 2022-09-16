using System;

namespace ManuelQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "MANUEL";
            string str2 = "manuel";
            if (String.Compare(str1, str2) > 0)
            {
                Console.WriteLine(str1 + " is greater than " + str2 + ".");
            }
            else
            {
                Console.WriteLine(str1 + " is less than or equal to " + str2 + ".");
            }
        }
    }
}
