using System;

namespace Module9
{
    public class Program
    {

        public static void Main(string[] args)
        {
            WritingUtensil pen = new WritingUtensil("red", true);
            Console.WriteLine(pen.ToString());
            Console.WriteLine(pen.write());

            Marker marker = new Marker("blue", true);
            Console.WriteLine(marker.ToString());
            Console.WriteLine(marker.write());
        }
    }
}