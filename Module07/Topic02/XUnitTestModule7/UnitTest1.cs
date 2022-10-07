using System;
using Xunit;

namespace XUnitTestModule7
{
    public class UnitTest1
    {
        [Fact]
        public void TestGradenPlanCarnationWateringDays()
        {
            // ARRANGE
            Module7.Flower flower = Module7.Flower.carnation;
            string expected = "A carnation needs watering on the Weekend";
            string actual;
            // ACT
            actual = Module7.Program.GardenPlan(flower);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGradenPlanPeonyWateringDays()
        {
            // ARRANGE
            Module7.Flower flower = Module7.Flower.peony;
            string expected = "A peony needs watering on Wednesday, Saturday";
            string actual;
            // ACT
            actual = Module7.Program.GardenPlan(flower);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGradenPlanPetuniaWateringDays()
        {
            // ARRANGE
            Module7.Flower flower = Module7.Flower.petunia;
            string expected = "A petunia needs watering on Monday, Friday";
            string actual;
            // ACT
            actual = Module7.Program.GardenPlan(flower);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGradenPlanDaisyWateringDays()
        {
            // ARRANGE
            Module7.Flower flower = Module7.Flower.daisy;
            string expected = "A daisy needs watering on Saturday";
            string actual;
            // ACT
            actual = Module7.Program.GardenPlan(flower);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGradenPlanRoseWateringDays()
        {
            // ARRANGE
            Module7.Flower flower = Module7.Flower.rose;
            string expected = "A rose needs watering on Tuesday, Friday";
            string actual;
            // ACT
            actual = Module7.Program.GardenPlan(flower);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGradenPlanTulipWateringDays()
        {
            // ARRANGE
            Module7.Flower flower = Module7.Flower.tulip;
            string expected = "A tulip needs watering on Monday, Thursday";
            string actual;
            // ACT
            actual = Module7.Program.GardenPlan(flower);
            // ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
