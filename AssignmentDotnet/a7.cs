using SampleConApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class a7_prime
    {
        static void Main(string[] args)
        {
            int number = Utilities.GetNumber("Enter the number you want to check whether it is prime or not");
            if (isPrime(number))
            {
                Console.WriteLine("Prime Number");
            }
            else Console.WriteLine("Not Prime number");
        }

        private static bool isPrime(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) return false;

            }
            return true;


        }
    }
}
