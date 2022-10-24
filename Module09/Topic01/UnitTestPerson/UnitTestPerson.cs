using System;
using Xunit;
using ModuleNine;

namespace UnitTestStudent
{
    public class UnitTestPerson
    {
        [Fact]
        public void TestPersonClassValidProperties()
        {
            // arrange
            Person disneyChar = new Person("Mickey", "Mouse");
            string expected = "Mickey Mouse";
            string actual;
            // act
            actual = disneyChar.ToString();
            // assert
            Assert.Equal(expected, actual);

        }
    }
}
