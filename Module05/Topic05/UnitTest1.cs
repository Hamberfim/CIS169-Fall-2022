using System;
using Xunit;
using Xunit.Sdk;

namespace Test
{
    public class UnitTest1
    {

        [Fact]
        public void TestStringToInt()
        {
            //Test a good value(string can be converted to int)
            // ARRANGE

            // ACT

            // ASSERT
            throw new XunitException("Not Implemented. Remove this statement when implemented.");
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
            actual = Module5.Program.ConvertToInt(input);
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
            actual = Module5.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringtoIntDoubleValue()
        {
            //Test a decimal value (string cannot be converted to int, it's decimal/double)
            // ARRANGE

            // ACT

            // ASSERT
            throw new XunitException("Not Implemented. Remove this statement when implemented.");
        }

        [Fact]
        public void TestValidateInput()
        {
            // Test a good value(int is greater than zero)
            // ARRANGE

            // ACT

            // ASSERT
            throw new XunitException("Not Implemented. Remove this statement when implemented.");
        }

        [Fact]
        public void TestValidateInputZero()
        {
            //Test edge case (int is zero)
            // ARRANGE

            // ACT

            // ASSERT
            throw new XunitException("Not Implemented. Remove this statement when implemented.");
        }

        [Fact]
        public void TestValidateInputNegative() {

            //Test bad UnitTest1(int is less than zero)
            // ARRANGE
            int inputInt = -5;
            // ACT
            // ASSERT
            Assert.False(Module5.Program.ValidateInput(inputInt)); 
        }

    }
}
