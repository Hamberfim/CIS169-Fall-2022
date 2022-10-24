using System;

namespace BuildingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Building class driver
            Building bld1 = new Building();
            bld1.Address = "747 Alpine Rdg, Boulder, CO 55555";
            bld1.Size = 900;
            Console.WriteLine(bld1.ToString());


            // House class driver
            House house1 = new House("34 Pinon Canon, Santa Fe, NM 55555", 1200, 3, 2);
            Console.WriteLine(house1.ToString());
        }
    }
}
