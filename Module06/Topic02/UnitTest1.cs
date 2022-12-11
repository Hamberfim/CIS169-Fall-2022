using System;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestCopyArray1()
        {
            // ARRANGE
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            int[] expected = new int[] { 1, 2, 3, 4 };
          

            // ACT
            int [] actual = Module6.CopyCompare.CopyArray(arr1);

            // ASSERT 
            Assert.Equal(expected, actual);
        }
		        [Fact]
        public void TestCopyArray2()
        {
            // ARRANGE
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };
          

            // ACT
            int [] actual = Module6.CopyCompare.CopyArray(arr1);

            // ASSERT 
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestCompareArrayDiffLengthsNotEqual()
        {
            string[] arr1 = new string[] { "C#", "Java", "Python" };
            string[] arr2 = new string[] { "C#", "Java", "Python", "C++" };
            bool expected = false;
            bool actual;

            // ACT
            actual = Module6.CopyCompare.CompareArrays(arr1, arr2);

            // ASSERT 
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestCompareArraySameLengthNotEqual()
        {
            string[] arr1 = new string[] { "C#", "Java", "Python", "C++" };
            string[] arr2 = new string[] { "C++", "Java", "Python", "C#" };
            bool expected = false;
            bool actual;

            // ACT
            actual = Module6.CopyCompare.CompareArrays(arr1, arr2);

            // ASSERT 
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestCompareArrayEqual()
        {
            // ARRANGE
            string[] arr1 = new string[] { "C#", "Java", "Python", "C++" };
            string[] arr2 = new string[] { "C#", "Java", "Python", "C++" };
            bool actual;

            // ACT
            actual = Module6.CopyCompare.CompareArrays(arr1, arr2);

            // ASSERT 
            Assert.True(actual);
        }
        public void TestCompareArraysNotEqual1()
        {
            // ARRANGE
            string[] arr1 = new string[] { "C#", "Java", "Python", "C++" };
            string[] arr2 = new string[] { "C#", "Java", "Javascript", "C" };
            bool actual;

            // ACT
            actual = Module6.CopyCompare.CompareArrays(arr1, arr2);

            // ASSERT 
            Assert.False(actual);
        }
		        [Fact]
        public void TestCompareArraysNotEqual2()
        {
            // ARRANGE
            string[] arr1 = new string[] { "C#", "Java", "Python", "C++" };
            string[] arr2 = new string[] { "C#", "Java", "Javascript", "C++" };
            bool actual;

            // ACT
            actual = Module6.CopyCompare.CompareArrays(arr1, arr2);

            // ASSERT 
            Assert.False(actual);
        }
    }
}
