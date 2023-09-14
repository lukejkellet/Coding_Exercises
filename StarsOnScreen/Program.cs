using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsOnScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numLines = 5; //Determines pyramid size.
            ArrayList pyramidLines = BuildPyramid(numLines);
            PrintPyramid(pyramidLines); //Print the built pyramid.
            Console.ReadLine();
        }

        static ArrayList BuildPyramid(int numLines)
        {
            ArrayList lines = new ArrayList(); // Create an empty list of lines
            for (int i = 0; i < numLines; i++) // Loop through the lines
            {
                StringBuilder lineBuilder = new StringBuilder();
                // Fill the line with empty spaces
                for (int x = 0; x < numLines - i - 1; x++)
                {
                    lineBuilder.Append(" ");
                }

                //Add the stars to the line
                for (int y = 0; y < i * 2 + 1; y++)
                {
                    lineBuilder.Append("*");
                }
                lines.Add(lineBuilder.ToString());
            }
            return lines;
        }
        static void PrintPyramid(ArrayList pyramidLines)
        {
            foreach (string line in pyramidLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
