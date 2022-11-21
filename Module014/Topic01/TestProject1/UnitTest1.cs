using ValidateStudent;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        // Test 1. A valid 900 as input(method returns true)
        [Fact]
        public void TestIsValid900()
        {
            // Arrange
            var student = new Student();
            string studentIdValue = "900000000";  // doesn't start with 9
            bool expected = true;
            bool actual;

            // Act
            actual = student.ValidateStudentID(studentIdValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 2. An invalid 900 number -- does not start with 9  (method returns false)
        [Fact]
        public void Test900DoesNOTstartWithNine()
        {
            // Arrange
            var student = new Student();
            string studentIdValue = "000000000";  // doesn't start with 9
            bool expected = false;
            bool actual;

            // Act
            actual = student.ValidateStudentID(studentIdValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 3. An invalid 900 number -- second character is not zero(method returns false)
        [Fact]
        public void Test900SecondCharIsNOTZeror()
        {
            // Arrange
            var student = new Student();
            string studentIdValue = "090000000";  // second char is no zero
            bool expected = false;
            bool actual;

            // Act
            actual = student.ValidateStudentID(studentIdValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 4. An invalid 900 number -- contains letters(method returns false)
        [Fact]
        public void Test900ContainsLetters()
        {
            // Arrange
            var student = new Student();
            string studentIdValue = "0A00B00k0";  // has alpha
            bool expected = false;
            bool actual;

            // Act
            actual = student.ValidateStudentID(studentIdValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 5. An invalid 900 number -- too long (how long is your student id?) length is nine: 900000000
        [Fact]
        public void TestIs900TooLong()
        {
            // Arrange
            var student = new Student();
            string studentIdValue = "0000000000";  // length is 10
            bool expected = false;
            bool actual;

            // Act
            actual = student.ValidateStudentID(studentIdValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 6. An invalid 900 number -- too short (how long is your student id?) length is nine: 900000000
        [Fact]
        public void TestIs900TooShort()
        {
            // Arrange
            var student = new Student();
            string studentIdValue = "000000";  // length is 6
            bool expected = false;
            bool actual;

            // Act
            actual = student.ValidateStudentID(studentIdValue);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
