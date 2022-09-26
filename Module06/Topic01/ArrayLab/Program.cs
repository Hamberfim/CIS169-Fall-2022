using System;

namespace ArrayLab
{
    class Program
    {
        // array method 
        public static string[] ProductNames()
        {
            return new string[] { "Apples", "Oranges", "Bananas", "Coffee", "Soda Pop" };
        }


        static void Main(string[] args)
        {
            // simple array
            const int LAP_SPEED_COUNT = 4;
            // declare and instantiate an array in one line
            double[] lapSpeed = new double[LAP_SPEED_COUNT];
            lapSpeed[0] = 12.4;
            lapSpeed[1] = 12.2;
            lapSpeed[2] = 11.9;
            lapSpeed[3] = 12.3;

            for (int i = 0; i < lapSpeed.Length; i++)
            {
                Console.WriteLine($"Lap {i + 1} speed was {lapSpeed[i]}");
            }
            Console.WriteLine();
            for (int i = lapSpeed.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Lap {i + 1} speed was {lapSpeed[i]}");
            }

            Console.WriteLine();
            // declare, instantiate, and initialize an array in one line
            decimal[] taxRange = new decimal[] { .009m, .007m, .005m, .003m, .001m };
            foreach (decimal t in taxRange)
            {
                Console.WriteLine($"The price is {t:p}");
            }

            Console.WriteLine();
            decimal[] prices = new decimal[] { 1.99m, 2.99m, 3.99m, 4.99m, 6.99m };
            // method array call
            string[] products = ProductNames();
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices.Length == products.Length)
                {
                    Console.WriteLine($"Product: {products[i]} - Price: {prices[i]}");
                }
                else
                {
                    Console.WriteLine("Can't merge procducts with prices.");
                }

            }

            Console.WriteLine();
            // copy an array so it's not the same reference
            double[] sourceArray = { 0, 1, 2, 3 };
            double[] copyPointsToRef = sourceArray;
            double[] targetSourceArray = new double[sourceArray.Length];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                targetSourceArray[i] = sourceArray[i];
                Console.WriteLine($"Source {sourceArray[i]}   | Copy {copyPointsToRef[i]}   | Target {targetSourceArray[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("A change has been made to only the copyPointsToRef array \n- this changed both the copy and the source because they are referencin the same place in memory");
            // change an item in the copyPointsToRef array
            copyPointsToRef[0] = 9;
            for (int i = 0; i < sourceArray.Length; i++)
            {
                Console.WriteLine($"Source {sourceArray[i]}   | Copy {copyPointsToRef[i]}   | Target {targetSourceArray[i]}");
            }

            Console.WriteLine();
            // compare an array item by item
            for (int i = 0; i < targetSourceArray.Length; i++)
            {
                if (sourceArray[i] == targetSourceArray[i])
                {
                    Console.WriteLine($"{sourceArray[i]} == {targetSourceArray[i]} same.");
                }
                else
                {
                    Console.WriteLine($"{sourceArray[i]} != {targetSourceArray[i]} NOT same.");
                }
            }


            Console.WriteLine();
            // compare an array item by item
            int[] num1 = { 99, 89, 79 };
            int[] num2 = { 99, 89, 79 };
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == num2[i])
                {
                    Console.WriteLine($"{num1[i]} == {num2[i]} same.");
                }
                else
                {
                    Console.WriteLine($"{num1[i]} != {num2[i]} NOT same.");
                }
            }
        }
    }
}
