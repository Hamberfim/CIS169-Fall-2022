using System;
/***************************************************************
* Name         : SportAbstractClass
* Author       : Anthony Hamlin
* Created      : 10/24/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is example of abstraction and the creation of sub-classes from the abstract class.
*                      Input : $$$$
*                      Output: $$$$
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace SportAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instructors driver
            Rugby rugby = new Rugby("Falcons", "Rugby Ball", 12);  // Can't use 'Sport' as the data type because there is no abstract FormTeam method to override
            Sport shotput = new ShotPut("Eagles", "Field and Shot put", 3);

            Console.WriteLine(rugby.ToString());
            Console.WriteLine(shotput.ToString());

            // add method calls as instructed here
            Console.WriteLine(rugby.Play());
            Console.WriteLine($"Rugby requires {rugby.FormTeam()} players to form a team.");
            Console.WriteLine(shotput.Play());

        }
    }
}
