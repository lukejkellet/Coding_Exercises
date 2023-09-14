using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sales made per day within a month.
            int[] sales = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };
            int longestSequence = 0; //Longest sequence of days with no sales.

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] == 0)
                {
                    int sequence = 0;
                    while (i < sales.Length && sales[i] == 0) //While sales[i] continues to be 0.
                    {
                        sequence++; //Increment current sequence value
                        i++; //Check the next day.
                    }
                    //If new sequence is bigger than the recorded longestSequence, update longestSequence.
                    if (sequence > longestSequence) { longestSequence = sequence; }
                }
            }
            Console.WriteLine("Longest sequence of days with no sales: {0}", longestSequence);
            Console.ReadLine();
        }
    }
}
