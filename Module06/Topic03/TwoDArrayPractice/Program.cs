using System;

namespace TwoDArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a 2d array using const
            const int PRICE_RANGE = 5;
            const int COLS = 3;
            decimal[,] productPriceRanges = new decimal[PRICE_RANGE, COLS]
            {
                { 0.99m, 1.99m, 2.99m },
                { 2.99m, 3.99m, 4.99m },
                { 4.99m, 5.99m, 6.99m },
                { 6.99m, 7.99m, 8.99m },
                { 8.99m, 9.99m, 10.99m },
            };

            int count = 0;
            // i < length
            for (int i = 0; i < PRICE_RANGE; i++)
            {
                // j <= length
                for (int j = 0; j < COLS; j++)
                {
                    if (count < 3)
                    {
                        Console.WriteLine("Oranges price range: $" + productPriceRanges[i, j]);
                    }
                    else if (count < 6)
                    {
                        Console.WriteLine("Snack Cakes price range: $" + productPriceRanges[i, j]);
                    }
                    else if (count < 9)
                    {
                        Console.WriteLine("Soda Pop price range: $" + productPriceRanges[i, j]);
                    }
                    else if (count < 12)
                    {
                        Console.WriteLine("Aged Cheese price range: $" + productPriceRanges[i, j]);
                    }
                    else
                    {
                        Console.WriteLine("Coffee price range: $" + productPriceRanges[i, j]);
                    }

                    count++;
                }
                Console.WriteLine();
            }

            // jagged Arrays
            // syntax: type[][] arrayName = new type[rowCount][];
            const int ROW_COUNT = 3;
            double[][] myDoublesArray = new double[ROW_COUNT][];

            // syntax for columns: arrayName[rowIndex] = new type[number of columns in this row];
            myDoublesArray[0] = new double[3];
            myDoublesArray[1] = new double[4];
            myDoublesArray[2] = new double[2];
            // syntax for values in the row columns: arrayName[rowIndex][columnIndex] = value;
            // row[index 0]
            myDoublesArray[0][0] = 10.1;
            myDoublesArray[0][1] = 11.2;
            myDoublesArray[0][2] = 9.5;

            // row[index 1]
            myDoublesArray[1][0] = 5.1;
            myDoublesArray[1][1] = 1.2;
            myDoublesArray[1][2] = 1.5;
            myDoublesArray[1][3] = 2.2;

            // row[index 2]
            myDoublesArray[2][0] = 6.3;
            myDoublesArray[2][1] = 3.9;

            Console.WriteLine();

            for (int i = 0; i < myDoublesArray.GetLength(0); i++)
            {
                for (int j = 0; j < myDoublesArray[i].Length; j++)
                {
                    Console.Write(myDoublesArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // as a single statement:
            int[][] myJaggedArr = { new int[] { 10, 9, 6, 4 }, new int[] { 3, 5, 12 }, new int[] { 7, 2, 1, 8, 11 } };

            foreach (int[] item in myJaggedArr)
            {
                for (int j = 0; j < item.Length; j++)
                {
                    Console.Write(item[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
