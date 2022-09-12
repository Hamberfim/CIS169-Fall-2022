using System;

namespace MedalWinner
{
    public class MedalWinnerProgram
    {
        public static string MedalWinner(string fName, string lName, string rank)
        {
            string result;
            fName = char.ToUpper(fName[0]) + fName.ToLower().Substring(1);
            lName = lName.ToUpper();
            result = fName + " " + lName + " " + rank;
            return result;
        }

        static void Main(string[] args)
        {
            // Call a method that returns the user's first name
            // first letter capitalized only
            // and the last name all capitalized followed by rank
            string winner1 = MedalWinner("Megan", "rapinoE", "1");
            string winner2 = MedalWinner("USA", "Women's Soccer", "1");
            string winner3 = MedalWinner("USA", "Women's Soccer", "1.5");
            Console.WriteLine("And the winner is ... {0:G}", winner1);
            Console.WriteLine("Expected: Megan RAPINOE 1");
            Console.WriteLine("And the winner is ... {0:G}", winner2);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER 1");
            Console.WriteLine("And the winner is ... {0:G}", winner3);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER 1.5");
        }
    }
}
