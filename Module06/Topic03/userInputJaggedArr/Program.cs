using System;

namespace userInputJaggedArr
{
    class Program
    {
        static void Main(string[] args)
        {
            // instructors code example
            const int NUMBER_OF_STUDENTS = 5;
            // declare and intialize Jagged Array
            int[][] scores = new int[NUMBER_OF_STUDENTS][];

            // get user input for scores
            for (int i = 0; i < scores.Length; i++)
            {
                bool numScoresInvalid = true;
                do
                {
                    Console.WriteLine("How many scores for student #{0}?", i + 1);
                    int numScores;
                    int score;
                    if (int.TryParse(Console.ReadLine(), out numScores))
                    {

                        numScoresInvalid = false;
                        scores[i] = new int[numScores];
                        for (int j = 0; j < scores[i].Length; j++)
                        {
                            bool scoreValid = false;
                            do
                            {
                                Console.WriteLine("Enter score #{0}", j + 1);
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


            // used nested loop to print array
            int index = 0;
            foreach (int[] item in scores)
            {
                Console.Write("Student #{0}:\t", ++index);
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
