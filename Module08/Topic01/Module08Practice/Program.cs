using System;
using System.Collections.Generic;
/***************************************************************
* Name         : Driver for House Class - via instructor provided code in House class
* Author       : Anthony Hamlin
* Created      : 10/14/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program utilizes instructors House Class
*                      Input : Write a driver to make a List or array of 5 objects of type House.
*                      Output: Print the List or array of House objects, calling the ToString() method.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace Module08House
{
    class Program
    {
        static void Main(string[] args)
        {
            // driver
            // write a driver to make a List or array of 5 objects of type House
            List<House> houseList = new List<House>();
            houseList.Add(new House("1122 Boogie-Woogie Ave", 2, 4));
            houseList.Add(new House("745 Elm St", 1, 2));
            houseList.Add(new House("6 Sunnyvale Lane", 3, 4));
            houseList.Add(new House("412 Oxnard Cir.", 3, 5));
            houseList.Add(new House("12 Cedar Way", 1, 1));


            // Print the List or array of House objects, calling the ToString() method
            foreach (var item in houseList)
            {
                Console.WriteLine(item);  // assuming you mean the override ToString() method in the House Class
            }

        }
    }
}
