using System;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Address Driver

            Address testAddress = new Address(123, "Main Street", "H2", "Small Town", "Iowa", 55555);
            Console.WriteLine(testAddress);
        }
    }
}
