using System;

namespace Module7
{
    // Enum - Your project enumerates the six flowers
    // (tulip, carnation, rose, peony, petunia, and daisy)
    // and the days of the week. Call the enumeration type Flower and WaterDays, respectively.
    [Flags]
    public enum Flower
    {
        tulip,
        carnation,
        rose,
        peony,
        petunia,
        daisy
    }

    [Flags]
    public enum WaterDays
    {
        None = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
        Weekend = Saturday | Sunday
    }


    public class Program
    {
        // Write a method GardenPlan() that accepts the Flower enum variable as a parameter
        // and uses case/switch statement to create a local string variable you will return for printing in the main method.
        // This return value will assign the watering scheduling.
        // You will use WaterDays enum in the method to build the string.
        // The method then returns a concatenated string of the flower name + "needs watering"  + watering days.
        // See output below, this also gives you the watering schedule to code.
        public static string GardenPlan(Flower flower)
        {
            string waterFlowerSchedule = "";

            switch (flower)
            {
                case Flower.tulip:
                    waterFlowerSchedule = "A " + flower + " needs watering on " + (WaterDays.Monday | WaterDays.Thursday);
                    break;
                case Flower.carnation:
                    waterFlowerSchedule = "A " + flower + " needs watering on the " + (WaterDays.Weekend);
                    break;
                case Flower.rose:
                    waterFlowerSchedule = "A " + flower + " needs watering on " + (WaterDays.Tuesday | WaterDays.Friday);
                    break;
                case Flower.peony:
                    waterFlowerSchedule = "A " + flower + " needs watering on " + (WaterDays.Wednesday | WaterDays.Saturday);
                    break;
                case Flower.petunia:
                    waterFlowerSchedule = "A " + flower + " needs watering on " + (WaterDays.Monday | WaterDays.Friday);
                    break;
                case Flower.daisy:
                    waterFlowerSchedule = "A " + flower + " needs watering on " + (WaterDays.Saturday);
                    break;
                default:
                    waterFlowerSchedule = "Watering schedule on hold, check back tomorrow";
                    break;
            }

            return waterFlowerSchedule;
        }
        /*
         * Excepted Output:
            * A carnation needs watering on the Weekend
            * A peony needs watering on Wednesday, Saturday
            * A petunia needs watering on Monday, Friday
            * A daisy needs watering on Saturday
            * A rose needs watering on Tuesday, Friday
            * A tulip needs watering on Monday, Thursday
         */


        static void Main(string[] args)
        {
            // In the Main() method, display each of the 6 rows by calling method GardenPlan() and printing to the console.
            // There is no need to declare another variable, you can use the enum Flower.
            Console.WriteLine(GardenPlan(Flower.carnation));
            Console.WriteLine(GardenPlan(Flower.peony));
            Console.WriteLine(GardenPlan(Flower.petunia));
            Console.WriteLine(GardenPlan(Flower.daisy));
            Console.WriteLine(GardenPlan(Flower.rose));
            Console.WriteLine(GardenPlan(Flower.tulip));




            // Add an xUnitTest project to your Module7 solution.
            // Copy from or download UnitTest1.cs and add the file to your xUnitTest project.
            // Do not change any tests or test names.
            // Don't forget to add the dependency and make your Program visibile to unit tests (public class Program).
            // This will test your method. Replace the not implemented exception in the UnitTest1.cs with appropriate Unit Tests

            Console.WriteLine();
        }
    }
}
