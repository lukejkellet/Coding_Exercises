using System;
using System.Collections.Generic;

namespace TwoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int> result = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (result != null)
            {
                Console.WriteLine("[" + result.Item1 + ", " + result.Item2 + "]");
            }
            else { Console.WriteLine("No pairs."); }
            Console.ReadLine();
        }

        public static Tuple<int, int> FindTwoSum(List<int> list, int targetSum)
        {
            for (int i = 0; i < list.Count; i++) // Loop through the list
            {
                // Starts j at index 1 to avoid checking the same index twice
                for (int j = i + 1; j < list.Count; j++)
                {
                    //Checks if the sum of the two numbers is equal to the target sum
                    if (list[i] + list[j] == targetSum) 
                    {
                        return new Tuple<int, int>(i, j); //Returns the index values of the two numbers
                    }
                }
            }
            return null;
        }
    }
}
