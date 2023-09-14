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
            int numLines = 5;
            ArrayList diamondLines = BuildDiamond(numLines);
            PrintDiamond(diamondLines); //Print the built diamond.
            Console.ReadLine();
        }

        static ArrayList BuildDiamond(int numLines)
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
        static void PrintDiamond(ArrayList diamondLines)
        {
            //Print lines in order.
            foreach (string line in diamondLines)
            {
                Console.WriteLine(line);
            }
            //Print lines in reverse order excluding the first line.
            for (int i = diamondLines.Count - 2; i >= 0; i--)
            {
                Console.WriteLine(diamondLines[i]);
            }
        }
    }
}
