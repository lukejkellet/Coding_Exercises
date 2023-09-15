using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int guesses = 6;
            bool gameWon = GuessTheNumber(randomNumber, guesses);
            if (gameWon)
            {
                Console.WriteLine("Well done! The randomly selected number was {0}", randomNumber);
            } else
            {
                Console.WriteLine("Oh no! You ran out of lives! The randomly selected number was {0)", randomNumber);
            }
            Console.ReadLine();
        }

        static bool GuessTheNumber(int number, int guesses)
        {
            while (guesses != 0)
            {
                Console.WriteLine("Guess the number between 1 and 100. \nLives Remaining: {0}", guesses);
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == number)
                {
                    return true;
                }
                else if (userGuess > number)
                {
                    Console.WriteLine("Your guess was too high");
                    guesses--;
                } else
                {
                    Console.WriteLine("Your guess was too low");
                    guesses--;
                }
            }
            return false;
        }
    }
}
