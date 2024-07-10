// An integer is said to be prime if it’s greater than 1 and divisible by only 1 and itself. For example, 2, 3, 5
// and 7 are prime, but 4, 6, 8 and 9 are not.
// a) Write a method that determines whether a number is prime.
// b) Use this method in an app that displays all the prime numbers less than 10,000.

using System;

namespace Week3
{
    class Question1
    {
        static bool isPrime(int val)
        {
            int flag = 0;

            for (int i = 2; i <= val / 2; i++)
            {
                if (val % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                // Console.WriteLine("The Entered value is prime no.");
                return true;
            }
            else
            {
                // Console.WriteLine("The Entered value is not a prime no.");
                return false;
            }
        }

        static void Main(string[] args)
        {
            int itteration = 10001;
            for (int i = 1; i <= itteration; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(" {0} ",i);
                }
            }
        }
    }
}