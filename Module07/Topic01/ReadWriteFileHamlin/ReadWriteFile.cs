using System;
using System.Collections;
using System.IO;
/***************************************************************
* Name         : ReadWriteFileHamlin
* Author       : Anthony Hamlin
* Created      : 10/06/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is reads file content and manipulates that content
*                      Input :  accepts a string and returns the formatted string
*                      Output:  write to a new file, called citynames.txt
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace ReadWriteFileHamlin
{
    class ReadWriteFile
    {
        public static string FormatName(string strValue)
        {
            strValue = strValue.ToLower();
            strValue = char.ToUpper(strValue[0]) + strValue.Substring(1);
            return strValue;
        }
        static void Main(string[] args)
        {
            // Write a Console App that does the following.
            // 1.) Read the following file of names of cites: cities.txt
            // get current working directory path
            string path = Directory.GetCurrentDirectory();
            // get to the project directory - up three directories (NOTE: 'Path' is not the same as 'path')
            string projDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // each Path.GetDirectoryName() call goes up one, to it's parent directory
            Console.WriteLine($"Note Working Path\n{projDir}\n");

            string FileToRead = "cities.txt";

            // Array List to hold formated content
            ArrayList strModified = new ArrayList();
            try
            {
                // directed at file in the working path (Project Directory)
                using (StreamReader sr = new StreamReader($"{projDir}/{FileToRead}"))
                {
                    // read the stream to a sting
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // A.) Formats the cities to have a capitalized first letter
                        //      Uses a method that you write FormatName() that accepts a string and returns the formatted string
                        string formatedLine = FormatName(line);
                        strModified.Add(formatedLine);
                    }
                }
            }
            catch (IOException err)
            {
                Console.WriteLine($"{FileToRead} file could not be read.");
                Console.WriteLine(err.Message);
            }

            // B.) Write these to a new file, called citynames.
            string writeFileName = "citynames.txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(projDir, writeFileName)))
            {
                foreach (var line in strModified)
                {
                    outputFile.WriteLine(line);
                }
                Console.WriteLine($"{writeFileName} file written to:\n{projDir}\\{writeFileName}\n");
            }

            // 2.) Open and append a new city, such as your hometown, to the file citynames.txt
            // Extra Credit: Handle two name cities(Des Moines) for up to 2 extra credit points.
            string[] additionalCredit = { "Ankeny", "Des Moines\n" };
            File.AppendAllLines(Path.Combine(projDir, writeFileName), additionalCredit);
            // 3.) Read the newly appended and print to the Console. (A way to double check your work as you go!)
            try
            {
                using (StreamReader sr = new StreamReader($"{projDir}/{writeFileName}"))
                {
                    // read the stream to a sting
                    string lines = sr.ReadToEnd();
                    Console.WriteLine(lines);
                }
            }
            catch (IOException err)
            {
                Console.WriteLine($"{writeFileName} File could not be read.");
                Console.WriteLine(err.Message);
            }


            // Make sure to NOT hardcode the file name or specific a path, eg C:/ User / yourusername / cities,
            // as this will not work on a different machine or allow others to use your code.
            // Also, do not use "MyEnvironment", this is also unique to your machine.

            // Your file can be "cities.txt" and place it in your "\source\repos\Module7\bin\Debug\netcoreapp#.#" or "\source\repos\Module7\bin\Debug\net#.#"
            // where #.# is the version of Visual Studio you are using (3.1, 5.0, etc). This is where citynames will be saved if you also do not specify a path. 

            // Submit your ReadWriteFile.cs file with the Academic Honesty Header included.
            // This is 15 points.
        }
    }
}
