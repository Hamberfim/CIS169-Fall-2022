using System;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_STUDENTS = 5;
            // Declare and Initialize Jagged Arrays
            int[][] scores = new int[NUMBER_OF_STUDENTS][];

            // Get user input for scores
            for (int i = 0; i < scores.Length; i++)
            {
                bool numScoresInvalid = true;
                do
                {                    
                    Console.WriteLine("How  many scores for student #{0}?", i + 1); // Array starts at zero
                    int numScores, score;
                    if (int.TryParse(Console.ReadLine(), out numScores))
                    {
                        numScoresInvalid = false; 
                        scores[i] = new int[numScores];
                        for (int j = 0; j < scores[i].Length; j++)
                        {
                            bool scoreValid = false;
                            do
                            {
                                Console.WriteLine("Entry score # {0}", j + 1);
                                scoreValid = int.TryParse(Console.ReadLine(), out score);
                                if (!scoreValid)
                                {
                                    continue;
                                }
                                scores[i][j] = score;
                            } while (!scoreValid);
                        }
                    } 
                } while (numScoresInvalid);
            }

            // using nested loops to print array
            Console.WriteLine("\nPrinting the jagged arrays:");
            int index = 0;
            foreach (int[] scoreRow in scores)
            {
                Console.Write("Student #{0}:\t", ++index); // array start 0
                // The current row is an array of any size, use Length property
                for (int j = 0; j < scoreRow.Length; j++)
                {
                    Console.Write(scoreRow[j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}