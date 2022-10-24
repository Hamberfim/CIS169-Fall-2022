using System;
using Xunit;
using ModuleNine;

namespace UnitTestStudent
{
    public class UnitTestStudent
    {
        [Fact]
        public void TestStudentClassValidProperties()
        {
            // arrange
            Student newStudent = new Student("Mickey", "Mouse", "0987A", 2);
            string expected = "Mickey Mouse student id: 0987A Year in school: 2";
            string actual;
            // act
            actual = newStudent.ToString();
            // assert
            Assert.Equal(expected, actual);

        }
    }
}
