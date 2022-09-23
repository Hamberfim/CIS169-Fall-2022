using System;
using Xunit;

namespace MethodTests
{
    public class UnitTest1
    {
        // Name your project Methods and Unit Tests MethodTests.
        //UNIT TESTING. Time to write your own unit tests. Watch the video to get you started!
        //    // ARRANGE
        //    // ACT
        //    // ASSERT
        //Include 4 Unit Tests to test ConvertToInt()
        //    Test a good value (string can be converted to int)
        //    Test an int non-score value (negative) 
        //    Test a string value (string cannot be converted to int, it's a string "st%$")
        //    Test a decimal value (string cannot be converted to int, it's decimal/double)
        //Include 3 Unit Tests to test ValidateInput()
        //    Test a good value (int is greater than zero)
        //    Test edge case (int is zero)
        //    Test bad value (int is less than zero)

        [Fact]
        public void TestStringToInt()
        {
            //Test a good value(string can be converted to int)
            // ARRANGE
            int expected, actual;
            expected = 23;
            string input = "23";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestStringToIntNegativeValue()
        {
            //Test an int non-score value(negative)
            // ARRANGE
            int expected, actual;
            expected = -1;
            string input = "-2";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringtoIntStringValue()
        {
            //Test a string value (string cannot be converted to int, it's a string "st%$")
            // ARRANGE
            int expected, actual;
            expected = -1; // Business Logic 
            string input = "a string";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringtoIntDoubleValue()
        {
            //Test a decimal value (string cannot be converted to int, it's decimal/double)
            // ARRANGE
            int expected, actual;
            expected = -1; // Business Logic 
            string input = "23.3";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidateInput()
        {
            // Test a good value(int is greater than zero)
            // ARRANGE
            int inputInt = 23;
            // ACT

            // ASSERT
            Assert.True(Methods.Program.ValidateInput(inputInt));
        }

        [Fact]
        public void TestValidateInputZero()
        {
            //Test edge case (int is zero)
            // ARRANGE
            int inputInt = 0;
            // ACT

            // ASSERT
            Assert.False(Methods.Program.ValidateInput(inputInt));
        }

        [Fact]
        public void TestValidateInputNegative()
        {

            //Test bad UnitTest1(int is less than zero)
            // ARRANGE
            int inputInt = -5;
            // ACT
            // ASSERT
            Assert.False(Methods.Program.ValidateInput(inputInt));
        }
    }
}
