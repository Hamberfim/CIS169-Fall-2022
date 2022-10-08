using System;

namespace LotoGenPractice
{

    /*  Time to play the lottery, without spending a dime! You can write your own random lottery numbers. You can give a try before looking at the solution! 
     *  Write and call the method -
     *  PowerBall()
     *      generates 5 random numbers between 1 and 64
     *      generates a random PowerBall between 5 and 64
     *      stores numbers in an array with the PowerBall at index zero
     *      returns the array
     *  Display the powerball at the end when displaying the numbers in Main(). */
    class LottoGenerator
    {
        public static int[] PowerBall()
        {
            const int MIN = 1;
            const int PB_MIN = 5;
            const int MAX = 65;
            const int MAX_NUMBERS = 6;
            Random number = new Random();
            int[] fiveRandPlusPowerBall = new int[MAX_NUMBERS];
            for (int i = 0; i < 5; i++)
            {
                fiveRandPlusPowerBall[i] = number.Next(MIN, MAX);
                //Console.WriteLine(fiveRandPlusPowerBall[i]);
            }
            fiveRandPlusPowerBall[5] = number.Next(PB_MIN, MAX);
            //Console.WriteLine(fiveRandPlusPowerBall[5]);
            return fiveRandPlusPowerBall;
        }
        static void Main(string[] args)
        {
            //PowerBall();
            int[] lotto = PowerBall();
            Console.WriteLine("======== Your Lotto Numbers ========");
            // llop thru all but last number, last number is powerball
            for (int i = 0; i < lotto.Length - 1; i++)
            {
                Console.Write($"  {lotto[i]}");
            }
            // last index number is powerball
            Console.Write($"  POWERBALL: {lotto[5]}");
            Console.WriteLine("\n======== Your Lotto Numbers ========");
        }
    }
}
