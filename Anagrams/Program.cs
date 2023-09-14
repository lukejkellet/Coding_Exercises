using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToMake = "star";
            String wordSequence = "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";
            String anagrams = ""; //String to hold anagrams

            //Convert word sequence to list of strings
            List<String> words = wordSequence.Split(',').ToList<String>();

            //Iterate through list of words
            foreach (String word in words)
            {
                //If the word is not the same length as the anagram, skip current word.
                if (word.Length != wordToMake.Length)
                {
                    continue;
                }
                //If the word is an anagram of the wordToMake, add it to the anagrams string.
                if (isAnagram(word, wordToMake))
                {
                    anagrams += word + ", ";
                }
            }
            Console.WriteLine("List of anagrams: {0}", anagrams);
            Console.ReadLine();
        }

        static bool isAnagram(String word, String wordToMake)
        {
            //Check if the current word is an anagram of the wordToMake.
            foreach (char letter in word)
            {
                if (wordToMake.Contains(letter))
                {
                    //Remove the letter from the wordToMake.
                    wordToMake = wordToMake.Remove(wordToMake.IndexOf(letter), 1);
                }
                else
                {
                    //Letter not found in wordToMake, and therefore not an anagram.
                    return false;
                }
            }
            return true;
        }

    }
}
