using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class Hangman
    {
        String hiddenWord = "";
        String answer = "";
        int guesses = 6;

        //Constructor
        public Hangman(String word)
        {
            //Set values for answer and hiddenWord
            answer = word;
            answer = answer.ToLower();
            for (int i = 0; i < answer.Length; i++)
            {
                hiddenWord += "_";
            }
        }

        //Check if the user guessed the word.
        public bool checkWord(String guess)
        {
            if (guess == answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Check if the user guessed a letter.
        public bool checkLetter(String guess)
        {
            if (answer.Contains(guess))
            {
                updateHiddenWord(guess);
                return true;
            }
            else
            {
                return false; //Lose a life.
            }
        }

        //Update hiddenWord
        public void updateHiddenWord(String guess)
        {
            //Replace all underscores at indexes where the letter is in the word.
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == guess[0])
                {
                    hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guess);
                }
            }
        }
        public void updateGuesses()
        {
            guesses--;
        }
        public int getGuesses()
        {
            return guesses;
        }
        //Get the word
        public String getAnswer()
        {
            return answer;
        }
        //Get the hidden word
        public String getHiddenWord()
        {
            return hiddenWord;
        }
    }
}