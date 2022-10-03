using System;
using System.Collections;
using System.Collections.Generic;


namespace ArraysListsMurach3
{
    class Program
    {
        static void Main(string[] args)
        {
            // List Collections - Untyped vs Typed
            // untyped ArrayList
            ArrayList nums1 = new ArrayList();
            nums1.Add(99);
            nums1.Add(35);
            nums1.Add(16);
            nums1.Add("Pizza");  // Will compile -RUN TIME ERROR  ???!!!
            foreach (var item in nums1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Typed List
            List<int> nums2 = new List<int>();
            nums2.Add(12);
            nums2.Add(23);
            nums2.Add(45);
            // nums2.Add("Pizza");  // won't compile - prevent runtime error
            foreach (var item in nums2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // insert into a List insert() 
            nums2.Insert(1, 15);
            nums2.Insert(3, 30);  // need to know that 15 is now in index pos 1 and that 23 moved to index pos 2
            foreach (var item in nums2)
            {
                Console.Write($"{item} ");  // Expected: 12, 15, 23, 30, 45
            }
            Console.WriteLine();

            // remove from List removeAt(index) 
            nums2.RemoveAt(2);
            foreach (var item in nums2)
            {
                Console.Write($"{item} ");  // Expected: 12, 15, 30, 45
            }
            Console.WriteLine();

            // declared
            SortedList<string, double> myPairs = new SortedList<string, double>(2);
            myPairs.Add("Pi", 3.14159265);
            myPairs.Add("Golden Ratio", 1.6180);


            // delcared/initialized
            SortedList<string, double> otherPairs = new SortedList<string, double>
            {
                {"Euler's Num",  2.7182}, { "Speed of Light MPS", 186282.0 }
            };

            // declared/initialized with an index
            SortedList<string, decimal> indexPairs = new SortedList<string, decimal>
            {
                ["pizza"] = 12.99m,
                ["tacos"] = 4.99m,
                ["pasta"] = 2.99m,
                ["nachos"] = 1.99m,
            };

            foreach (var item in indexPairs)
            {
                Console.Write($"{item} ");  // order is sorted by key
            }
            Console.WriteLine();

            // remove from list remove(key)
            indexPairs.Remove("pasta");
            foreach (var item in indexPairs)
            {
                Console.Write($"{item} ");  // order is sorted by key
            }
            Console.WriteLine();

            // ContainsKey()/ContainsValue()  - return bool
            Console.WriteLine(indexPairs.ContainsKey("tacos"));
            Console.WriteLine(myPairs.ContainsValue(1.6180));

            // KeyValuePair Loop
            foreach (KeyValuePair<string, decimal> item in indexPairs)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
