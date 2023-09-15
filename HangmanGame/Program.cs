using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pick a word at random.
            Random random = new Random();
            String[] wordList = { "apple", "banana", "orange", "pear", "grape", "pineapple", "strawberry", "blueberry", "raspberry", "blackberry" };
            String word = wordList[random.Next(0, wordList.Length)];
            int guesses = 6;
            bool gameWon = Hangman(word, guesses);
            if (gameWon)
            {
                Console.WriteLine("Well done! You successfully deciphered the word!");
            }
            else
            {
                Console.WriteLine("Oh no! You ran out of lives! The word was {0}", word);
            }
            Console.ReadLine();
        }
        static bool Hangman(String word, int guesses)
        {
            //Convert word to underscores.
            String hiddenWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                hiddenWord += "_";
            }

            while (guesses != 0)
            {
                String userGuess;
                Console.WriteLine("Guess the word, or one of the letters you think might be in it. \nHidden Word: {0} \nLives Remaining: {1}", hiddenWord, guesses);
                userGuess = Console.ReadLine();
                userGuess = userGuess.ToLower();

                if (userGuess == word) //User guessed correctly.
                {
                    return true;
                }
                //Check if the user guessed a letter, and if that letter is in the word.
                else if (userGuess.Length == 1 && word.Contains(userGuess))
                {
                    //Replace all instances of the letter in the hidden word.
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == userGuess[0])
                        {
                            hiddenWord = hiddenWord.Remove(i, 1).Insert(i, userGuess);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Your guess was incorrect");
                    guesses--;
                }
            }
            return false; //Executes if the user ran out of lives.
        }


    }
}