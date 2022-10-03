using System;

namespace ArraysListsMurach2
{
    class Program
    {
        // return an array
        public static string[] ReturnRandAdj()
        {
            Random rnd = new Random();
            int selectOne = rnd.Next(0, 7);
            int selectTwo = rnd.Next(0, 7);
            string[] returnArr = new string[2];
            string[] encouraging = { "helpful", "kindly", "gracious", "encouraging", "cautious", "keen", "enthusiastic" };
            returnArr[0] = encouraging[selectOne];
            returnArr[1] = encouraging[selectTwo];

            return returnArr;
        }

        static void Main(string[] args)
        {
            // return an array
            string[] rndAdjs = ReturnRandAdj();
            foreach (var item in rndAdjs)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // array element range use
            string[] adjDesc = { "shocking", "melodic", "heavy", "hypnotic", "harsh", "burly", "somber" };
            // range start to end
            var startEnd = adjDesc[0..7];
            foreach (var item in startEnd)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            var middle = adjDesc[2..5];
            foreach (var item in middle)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();






        }
    }
}
