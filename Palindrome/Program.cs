using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] inputs = { "madam", "step on no pets", "book" };

            //Loop through the inputs
            foreach (String word in inputs)
            {
                StringBuilder reversedWord = new StringBuilder();

                //Loop through the word backwards
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    //Append each character to reversedWord
                    reversedWord.Append(word[i]);
                }
                //Check if the reversed word is the same as the original word
                if (word.Equals(reversedWord.ToString()))
                {
                    Console.WriteLine(word + " is a palindrome");
                }
                else
                {
                    Console.WriteLine(word + " is not a palindrome");
                }
            }
            Console.ReadLine();
        }
    }
}
