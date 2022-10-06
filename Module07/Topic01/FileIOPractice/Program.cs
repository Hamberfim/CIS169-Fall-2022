using System;
using System.IO;

namespace FileIOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // some set up first
            // get current working directory path
            string path = Directory.GetCurrentDirectory();
            // Console.WriteLine(path);  project directory main folder path is up three dirs ../../../--------
            // get to the project directory - up three directories (NOTE: 'Path' is not the same as 'path')
            string projDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));  // each Path.GetDirectoryName() call goes up one, to it's parent directory
            // Console.WriteLine(projDir);

            // open/read a text file
            try
            {
                using (StreamReader sr = new StreamReader($"{projDir}/myTextFile.txt"))
                {
                    // read the stream to a sting
                    string lines = sr.ReadToEnd();
                    Console.WriteLine(lines);
                }
            }
            catch (IOException err)
            {
                Console.WriteLine("File could not be read.");
                Console.WriteLine(err.Message);
            }

            // string array for lines to write
            string[] textLines = { "flowery", "nimble", "secretive", "zesty" };

            // can use env specified path: string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // I have path to project directory set above = 'projDir'

            // write the string array above to a text file
            string fileName = "myWriteLines.txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(projDir, fileName)))
            {
                foreach (var line in textLines)
                {
                    outputFile.WriteLine(line);
                }
                Console.WriteLine($"File written to: {projDir}\\{fileName}");
            }

            // write, with option to append
            // string with a line of text
            string firstLineTxt = "First Line Text" + Environment.NewLine;
            // can also be written with non-unix ->'\r\n' and just '\n' on unix
            string[] secondLineTxt = { "Second Line Text", "Another Line Text", "And Another Line Text\n" };

            // set path using the Environment.GetFolderPath();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the text to a new file named "WriteFile.txt".
            File.WriteAllText(Path.Combine(docPath, "WriteAppendFile.txt"), firstLineTxt);

            // Append new lines of text to the file
            File.AppendAllLines(Path.Combine(docPath, "WriteAppendFile.txt"), secondLineTxt);

            Console.WriteLine();
        }
    }
}
