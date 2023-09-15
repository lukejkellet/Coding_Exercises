using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NextPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool primeFound = false;
            int next_num = userInput + 1;

            while (!primeFound)
            {
                if (checkPrime(next_num))
                {
                    primeFound = true;
                    Console.WriteLine($"The next prime number after {userInput} is {next_num}");
                }
                next_num++; //Increments next_num and repeats the process.
            }
            Console.ReadLine();
        }

        static bool checkPrime(int number)
        {
            if (number <= 1 || (number % 2 == 0 && number != 2))
            { //Number is less than 1, or number is divisible by 2 and is NOT 2
                return false;
            }
            else if (number == 2)
            { //Number is 2
                return true;
            }
            else
            {
                for (int i = 3; i * i <= number; i += 2)
                { //Checks to see if number is divisible by anything other than itself.
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
