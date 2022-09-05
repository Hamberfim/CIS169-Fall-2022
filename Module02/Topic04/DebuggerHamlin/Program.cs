using System;

namespace DebuggerHamlin
{
    class Program
    {
        private static string MedalWinner(string fName, string lName, string rank)
        {
            string result;
            fName = char.ToUpper(fName[0]) + fName.ToLower().Substring(1);
            lName = lName.ToUpper(); ;
            result = fName + " " + lName;

            try
            {
                result = result + " Rank: " + Convert.ToInt32(rank).ToString();
            }
            catch (FormatException e)
            {
                try
                {
                    result = result + " Rank: " + Convert.ToDecimal(rank).ToString();
                }
                catch (FormatException e2)
                {
                    result = result + " Rank: undetermined";
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Call a method that returns the user's first name
            // first letter capitalized only
            // and the last name all capitalized followed by rank  
            // Anthony Hamlin  -  add your first and last name on the final comment line ??
            string winner1 = MedalWinner("MEGAN", "rapinoE", "1");
            string winner2 = MedalWinner("USA", "Women's Soccer", "1");
            string winner3 = MedalWinner("USA", "Women's Soccer", "1.5");
            string winner4 = MedalWinner("USA", "Men's Soccer", "GOLD");
            Console.WriteLine("And the winner is ... {0:G}", winner1);
            Console.WriteLine("Expected: Megan RAPINOE Rank: 1");
            Console.WriteLine("And the winner is ... {0:G}", winner2);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1");
            Console.WriteLine("And the winner is ... {0:G}", winner3);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1.5");
            Console.WriteLine("And the winner is ... {0:G}", winner4);
            Console.WriteLine("Expected: Usa MEN'S SOCCER Rank: undetermined");
        }
    }
}
