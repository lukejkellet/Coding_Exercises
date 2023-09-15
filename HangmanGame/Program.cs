using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call fuction to fetch words from file
            String[] wordList = GetWords();
            Random random = new Random();
            Hangman hangman = new Hangman(wordList[random.Next(0, wordList.Length)]);
            bool gameWon = false;

            //Game loop
            while (true)
            {
                String userGuess;
                Console.WriteLine("Guess the word, or one of the letters you think might be in it. \nHidden Word: {0} \nLives Remaining: {1}", hangman.getHiddenWord(), hangman.getGuesses());
                userGuess = Console.ReadLine();
                userGuess = userGuess.ToLower();

                if (hangman.checkWord(userGuess)) //User guessed correctly.
                {
                    gameWon = true;
                    break; //Victory
                }
                //Check if the user guessed a letter
                else if (hangman.checkLetter(userGuess))
                {
                    hangman.updateHiddenWord(userGuess);
                }
                else
                {
                    Console.WriteLine("Your guess was incorrect");
                    hangman.updateGuesses();
                }
                //Check remaining guesses
                if (hangman.getGuesses() == 0) //returns true if the user has lives remaining.
                {
                    break; //Game over
                }
            }

            if (gameWon)
            {
                Console.WriteLine("Well done! You successfully deciphered the word {0}!", hangman.getAnswer());
            }
            else
            {
                Console.WriteLine("Oh no! You ran out of lives! The word was {0}", hangman.getAnswer());
            }
            Console.ReadLine();
        }

        static String[] GetWords()
        {
            String[] wordList;
            try
            {
                //Set path to file
                string path = @"files/words.txt";
                //Get file from path.
                string filename = Path.GetFileName(path);

                using (var streamreader = new StreamReader(path))
                {
                    //Fill array with words from file.
                    wordList = streamreader.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                }
                return wordList; //Return array to main.
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read.");
                Console.ReadLine();
                Environment.Exit(0); //Exit program.
            }
            return null;
        }
    }
}