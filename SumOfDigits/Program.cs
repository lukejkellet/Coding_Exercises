using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = { 12, 123, 5000 };
            foreach (int num in inputs)
            {
                int sum = 0;
                for (int i = 0; i < num.ToString().Length; i++)
                {
                    sum += int.Parse(num.ToString()[i].ToString());
                }
                Console.WriteLine("Sum of digits of {0} is {1}", num, sum);
            }
            Console.ReadLine();
        }
    }
}
