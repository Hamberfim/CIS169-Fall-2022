using System;


namespace ArraysMurach
{
    class Program
    {
        static void Main(string[] args)
        {
            // one-dimensional array syntax:
            // type[] arrayName;
            // arrayName = new type[arrayLength];
            // type[] arrayName = new type[arrayLength];

            const int PRICES_LENGTH = 6;
            decimal[] prices;
            prices = new decimal[PRICES_LENGTH];
            prices[0] = 0.99m;
            prices[1] = 1.99m;
            prices[2] = 1.99m;
            prices[3] = 2.99m;
            prices[4] = 2.99m;
            prices[5] = 3.99m;

            // declared and assigned values
            decimal[] percents = new decimal[3] { 0.03m, 0.05m, 0.07m };
            decimal[] taxRange = { 0.03m, 0.05m, 0.07m };  // length is inferred

            const int TOTALS_LENGTH = 3;
            decimal[] totals = new decimal[TOTALS_LENGTH];
            // add two prices with an applied taxRange
            totals[0] = (prices[0] + prices[1]) + ((prices[0] + prices[1]) * taxRange[0]);
            totals[1] = (prices[2] + prices[3]) + ((prices[2] + prices[3]) * taxRange[1]);
            totals[2] = (prices[4] + prices[5]) + ((prices[4] + prices[5]) * taxRange[2]);



            // display totals array
            string totalsStr = "";
            foreach (var item in totals)
            {
                // Console.Write(item + " ");  // alternative
                totalsStr += $"{item:c2} ";  // note space at end
            }
            Console.WriteLine("Totals Array items: " + totalsStr);

            Console.WriteLine();

            // two-dimensional array syntax:
            // type[,] arrayName = new type[rowCount, columnCount];
            // type[,] arrayName = {{1, 2}, {3, 4}, {5, 6}};  // 3 rows x 2 colmuns array
            const int ROW_COUNT = 3;
            const int COLUMN_COUNT = 2;
            int[,] numOneArr = new int[ROW_COUNT, COLUMN_COUNT];

            // value assignments
            numOneArr[0, 0] = 1;
            numOneArr[0, 1] = 2;
            numOneArr[1, 0] = 3;
            numOneArr[1, 1] = 4;
            numOneArr[2, 0] = 5;
            numOneArr[2, 1] = 6;

            // Array.Copy(fromArray, toArray, array.length);  -copy some or all of an array
            int[] num1 = new int[4] { 9, 7, 5, 3 };
            int[] num2 = new int[4];
            int[] num3 = new int[3];
            Array.Copy(num1, num2, num1.Length);
            foreach (var item in num2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // sort an array
            Array.Sort(num2);
            foreach (var item in num2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // copy some of the array
            string[] firstNames = { "Tom", "Linda", "Tina" };
            string[] lastTwofirstNames = new string[2];
            // syntax; Array.Copy(fromArray, fromIndex, toArray, toIndex, length);
            Array.Copy(firstNames, 1, lastTwofirstNames, 0, 2);
            foreach (var item in lastTwofirstNames)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            // BinarySearch an array - the array must be in ascending order for it to work sort() method must be used first
            string[] friends = { "Teddy", "Linda", "Bob", "Tina" };
            Array.Sort(friends);
            int indexPos = Array.BinarySearch(friends, "Bob");  // 
            Console.WriteLine(friends[indexPos] + " after sort is at index " + indexPos);

            Console.WriteLine();
            // create and assign
            // var freshProduce = new[,] { { "Apples", "Fuji" }, { "Oranges", "Navel" }, { "Avacados", "Haas" } };
            string[,] freshProduce = { { "Fuji", "Apples" }, { "Navel", "Oranges" }, { "Haas", "Avacados" } };

            // display  - GetLength(demension) // GetUpperBound(demension) - GetLowerBound(demension) 
            for (int i = 0; i < freshProduce.GetLength(0); i++)
            {
                for (int j = 0; j < freshProduce.GetLength(1); j++)
                {
                    Console.Write($"{freshProduce[i, j]} ");
                }
                Console.WriteLine();  // new line after each loop
            }
            Console.WriteLine();


            // jagged array syntax:
            // type[][] arrayName = new type[rowCount][];
            // type[][] arrayName = { new type [columnCount] {comma seperated value, comma seperated value,},
            //                        new type [columnCount] {comma seperated value, comma seperated value,},
            //                        new type [columnCount] {comma seperated value, comma seperated value,} };  

            int[][] numJaggedArr = new int[3][];
            // arrayName[rowIndex] = new type[columnCount];
            numJaggedArr[0] = new int[2];  // two columns
            numJaggedArr[1] = new int[4];  // four columns
            numJaggedArr[2] = new int[2];  // two columns
            // assignment syntax: arrayName[rowIndex][columnIndex] = value;
            numJaggedArr[0][0] = 1;
            numJaggedArr[0][1] = 2;
            numJaggedArr[1][0] = 3;
            numJaggedArr[1][1] = 4;
            numJaggedArr[1][2] = 5;
            numJaggedArr[1][3] = 6;
            numJaggedArr[2][0] = 7;
            numJaggedArr[2][1] = 8;


            // display
            for (int i = 0; i < numJaggedArr.GetLength(0); i++)
            {
                // uses the zero demension index length
                for (int j = 0; j < numJaggedArr[i].Length; j++)
                {
                    Console.Write($"{numJaggedArr[i][j]} ");
                }
                Console.WriteLine();  // new line after each loop
            }
            Console.WriteLine();

            double[][] doublesJaggedArr = { new double[3] { 22.2, 19.3, 10.3},  // row one (index zero)
                                      new double[6] { 0.09, 10.2, 0.08, 0.77, 0.95, 1.73} };  // row two (index one)

            // arrayName[rowIndex][columnIndex]
            Console.WriteLine(doublesJaggedArr[0][0]);
            Console.WriteLine(doublesJaggedArr[0][1]);
            Console.WriteLine(doublesJaggedArr[1][5]);  // last item in second row



        }
    }
}
