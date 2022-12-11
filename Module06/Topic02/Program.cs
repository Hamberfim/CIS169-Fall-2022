using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Module6
{
    public class CopyCompare
    {
        public static int[] copyArray(int[] intArray)
        {
            int[] localArray = new int[intArray.Length];

            for (int i = 0; i < intArray.Length; i++)
            {
                localArray[i] = intArray[i];
            }
            return localArray;
        }
        public static bool CompareArrays(string[] arr1, string[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!arr1[i].Equals(arr2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}