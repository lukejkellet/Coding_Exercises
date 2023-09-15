using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrmeNthPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            Console.WriteLine("Enter the position of the prime number you want to see: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(primes[input - 1]); //Base-zero array means we need to subtract 1 from the input.
            Console.ReadLine();
        }
    }
}
