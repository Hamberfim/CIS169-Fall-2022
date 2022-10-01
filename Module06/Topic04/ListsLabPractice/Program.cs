using System;
using System.Collections.Generic;

namespace ListsLabPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // collections - List
            List<string> activities = new List<string> { "swim", "bike", "run", "yoga", "meditation" };
            // search
            int indexPosYoga = activities.IndexOf("yoga");
            Console.WriteLine($"{activities[indexPosYoga]} index position is {indexPosYoga}");
            Console.WriteLine();

            List<string> foods = new List<string> { "pizza", "taco", "pasta", "pie", "ice cream" };

            // loops - search
            for (int i = 0; i < foods.Count; i++)
            {
                Console.WriteLine($"{foods[i]} index position is {i}");
            }
            Console.WriteLine();

            List<string> cars = new List<string> { "fiat", "chevy", "ford", "honda", "buick" };
            foreach (var item in cars)
            {
                Console.WriteLine($"{item} is at index {cars.IndexOf(item)} and its type is {item.GetTypeCode()}");
            }
            Console.WriteLine();

            // copy
            List<double> doubleSource = new List<double> { 22.3, 45.8, 15.9, 12.5 };  // size inferred & self regulated
            List<double> targetCopy;
            targetCopy = new List<double>(doubleSource);
            foreach (var item in doubleSource)
            {
                Console.WriteLine($"doubleSource: {item}");
            }
            foreach (var item in targetCopy)
            {
                Console.WriteLine($"targetCopy: {item}");
            }

            // add an item to source
            doubleSource.Add(99.9);
            foreach (var item in doubleSource)
            {
                Console.WriteLine($"doubleSource: {item}");
            }
            foreach (var item in targetCopy)
            {
                Console.WriteLine($"targetCopy: {item}");
            }

            Console.WriteLine();
        }
    }
}
