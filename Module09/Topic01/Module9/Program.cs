using System;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Address Driver
            Address testAddress = new Address(123, "Main Street", "H2", "Small Town", "Iowa", 55555);
            Console.WriteLine(testAddress.ToString());

            Console.WriteLine();  // space in output
            // house driver
            House testHouse = new House(321, "Blakes Cir.", "B1", "Turnip Town", "Iowa", 55555);
            testHouse.NumberBedrooms = 3;
            testHouse.NumberBathrooms = 1;
            Console.WriteLine(testHouse.ToString());

            Console.WriteLine();  // space in output
            // test empty apt return -- assuming a form with an empty string input for apt
            House testHouseNoApt = new House(555, "Mill RD", "", "Turnip Town", "Iowa", 55555);
            testHouseNoApt.NumberBedrooms = 3;
            testHouseNoApt.NumberBathrooms = 1;
            Console.WriteLine(testHouseNoApt.ToString());
        }
    }
}
